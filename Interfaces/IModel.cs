using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  IModel
{
    /// <summary>
    /// �Ƿ���ڴ���
    /// </summary>
    /// <param name="proxyName"></param>
    /// <returns></returns>
    //
    bool HasProxy(string proxyName);
    /// <summary>
    /// ע�����
    /// </summary>
    /// <param name="proxy"></param>
    //
    void RegisterProxy(IProxy proxy);
    /// <summary>
    /// �Ƴ�����
    /// </summary>
    /// <param name="proxyName"></param>
    /// <returns></returns>
    //
    IProxy RemoveProxy(string proxyName);
    /// <summary>
    /// �ظ�����
    /// </summary>
    /// <param name="proxyName"></param>
    /// <returns></returns>
    //
    IProxy RetrieveProxy(string proxyName);
}
