using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ¥˙¿Ì»À
/// </summary>
public class Proxy : Notifier, IProxy, INotifier
{
    protected object m_data;
    protected string m_proxyName;
    public static string NAME = "Proxy";
    public Proxy()
    {

    }
    public Proxy(string proxyName)
    {
        this.m_proxyName = (proxyName != null) ? proxyName : NAME;
    }
    public Proxy(string proxyName, object data)
    {
        this.m_proxyName = (proxyName != null) ? proxyName : NAME;
        if (data != null)
        {
            this.m_data = data;
        }
    }

    public object Data { get { return this.m_data; } set { this.m_data = value; } }

    public string ProxyName { get { return this.m_proxyName; } }

    public void OnRegister()
    {

    }

    public void OnRemove()
    {

    }
}
