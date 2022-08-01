using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 编写接口数据
/// </summary>
public interface INotifier
{
    void SendNotification(string notificationName);

    void SendNotification(string notificationName, object body);

    void SendNotification(string notificationName, object body,string type);
}
