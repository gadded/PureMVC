using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 观察者
/// </summary>
public interface IObserver
{
    /// <summary>
    /// 比较上下文
    /// </summary>
    /// <param name="objc"></param>
    /// <returns></returns>
    //对比NotifyContext
    bool CompareNotifyContext(object objc);

    //通知观察者
    void NotifyObserver(INotification notification);

    //记录是Mediator或Command
    object NotifyContext { set; }

    //通知方法
    string NotifyMethod { set; }
}
