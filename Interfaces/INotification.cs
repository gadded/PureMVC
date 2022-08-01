using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 通知用的一个接口，应该是观察者通知用的
/// </summary>
public interface INotification
{
    //重写通知用于调试输出
    string ToString();

    //通知事件
    object Body { get; set; }

    //通知名称
    string Name { get; set; }

    //通知类型
    string Type { get; set; }
}
