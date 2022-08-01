using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
public interface IProxy
{
    //ע��
    void OnRegister();
    //ע��
    void OnRemove();
    //ԭʼ����
    object Data { get; set; }
    //��������
    string ProxyName { get; }
}
