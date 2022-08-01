using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ֪ͨ��
/// </summary>
public class Notifier : INotifier
{
    //����Facade��������
    private IFacade facade = Facade.Get;

    public void SendNotification(string notificationName)
    {
        this.facade.SendNotification(notificationName);
    }

    public void SendNotification(string notificationName, object body)
    {
        this.facade.SendNotification(notificationName,body);
    }

    public void SendNotification(string notificationName, object body, string type)
    {
        this.facade.SendNotification(notificationName,body,type);
    }
    protected IFacade Facade1
    {
        get
        {
            return this.facade;
        }
    }
}
