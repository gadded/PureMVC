using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �۲���
/// </summary>
public interface IObserver
{
    /// <summary>
    /// �Ƚ�������
    /// </summary>
    /// <param name="objc"></param>
    /// <returns></returns>
    //�Ա�NotifyContext
    bool CompareNotifyContext(object objc);

    //֪ͨ�۲���
    void NotifyObserver(INotification notification);

    //��¼��Mediator��Command
    object NotifyContext { set; }

    //֪ͨ����
    string NotifyMethod { set; }
}
