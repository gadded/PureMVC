using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
public interface ICommand
{
    /// <summary>
    /// ִ��֪ͨ�¼�
    /// </summary>
    /// <param name="notification"></param>
    void Execute(INotification notification);
}
