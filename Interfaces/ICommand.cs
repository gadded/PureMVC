using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 命令
/// </summary>
public interface ICommand
{
    /// <summary>
    /// 执行通知事件
    /// </summary>
    /// <param name="notification"></param>
    void Execute(INotification notification);
}
