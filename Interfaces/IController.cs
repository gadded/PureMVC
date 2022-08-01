using System.Collections;
using System;

public interface IController
{
    /// <summary>
    /// ִ���¼�
    /// </summary>
    /// <param name="notification"></param>
    void ExecuteCommand(INotification notification);
    /// <summary>
    /// �Ƿ�����¼�
    /// </summary>
    /// <param name="notificationName"></param>
    /// <returns></returns>
    bool HasCommand(string notificationName);
    /// <summary>
    /// ע���¼�
    /// </summary>
    /// <param name="notificatioName"></param>
    /// <param name="commandType"></param>
    void RegisterCommand(string notificatioName, Type commandType);
    /// <summary>
    /// �Ƴ��¼�
    /// </summary>
    /// <param name="notificationName"></param>
    void RemoveCommand(string notificationName);
}
