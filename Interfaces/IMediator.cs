using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
public interface IMediator
{
    //����֪ͨ
    void HandleNotification(INotification notification);
    //֪ͨ������
    IList<string> ListNotificationInterests();
    //ע��
    void OnRegister();
    //�Ƴ�
    void OnRemove();
    //����
    string MediatorName { get; }
    //��ͼ���  �����Ǵ��object����
    object ViewComponent { get; set; }
}
