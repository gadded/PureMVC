using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ֪ͨ�õ�һ���ӿڣ�Ӧ���ǹ۲���֪ͨ�õ�
/// </summary>
public interface INotification
{
    //��д֪ͨ���ڵ������
    string ToString();

    //֪ͨ�¼�
    object Body { get; set; }

    //֪ͨ����
    string Name { get; set; }

    //֪ͨ����
    string Type { get; set; }
}
