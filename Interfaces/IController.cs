using System.Collections;
using System;

public interface IController
{
    /// <summary>
    /// 执行事件
    /// </summary>
    /// <param name="notification"></param>
    void ExecuteCommand(INotification notification);
    /// <summary>
    /// 是否存在事件
    /// </summary>
    /// <param name="notificationName"></param>
    /// <returns></returns>
    bool HasCommand(string notificationName);
    /// <summary>
    /// 注册事件
    /// </summary>
    /// <param name="notificatioName"></param>
    /// <param name="commandType"></param>
    void RegisterCommand(string notificatioName, Type commandType);
    /// <summary>
    /// 移除事件
    /// </summary>
    /// <param name="notificationName"></param>
    void RemoveCommand(string notificationName);
}
