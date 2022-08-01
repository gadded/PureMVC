using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
/// <summary>
/// �۲�����
/// </summary>
public class Observer : IObserver
{
    private object m_notifyContext;
    private string m_notifyMethod;//��������
    protected readonly object m_syncRoot = new object();

    public Observer(string notifyMethod, object notifyContext)
    {
        this.m_notifyMethod = notifyMethod;
        this.m_notifyContext = notifyContext;
    }

    public object NotifyContext { private get { return this.m_notifyContext; } set { this.m_notifyContext = value; } }
    public string NotifyMethod { private get { return this.m_notifyMethod; } set { this.m_notifyMethod = value; } }
    /// <summary>
    /// �Ƚ���Ϣ���Ƿ���ͬ
    /// </summary>
    /// <param name="objc"></param>
    /// <returns></returns>
    public bool CompareNotifyContext(object objc)
    {
        lock (this.m_syncRoot)
        {
            return this.NotifyContext.Equals(objc);
        }
    }
    /// <summary>
    /// ֪ͨ�۲���
    /// </summary>
    /// <param name="notification"></param>
    public void NotifyObserver(INotification notification)
    {
        object notifyContext;
        lock (this.m_syncRoot)
        {
            notifyContext = this.NotifyContext;
        }
        Type type = notifyContext.GetType();
        BindingFlags bindingAttr = BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase;
        MethodInfo method = type.GetMethod(this.NotifyMethod, bindingAttr);
        method.Invoke(notifyContext, new object[] { notification });
    }
}
