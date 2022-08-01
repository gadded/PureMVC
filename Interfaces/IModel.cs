using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  IModel
{
    /// <summary>
    /// 是否存在代理
    /// </summary>
    /// <param name="proxyName"></param>
    /// <returns></returns>
    //
    bool HasProxy(string proxyName);
    /// <summary>
    /// 注册代理
    /// </summary>
    /// <param name="proxy"></param>
    //
    void RegisterProxy(IProxy proxy);
    /// <summary>
    /// 移除代理
    /// </summary>
    /// <param name="proxyName"></param>
    /// <returns></returns>
    //
    IProxy RemoveProxy(string proxyName);
    /// <summary>
    /// 回复代理
    /// </summary>
    /// <param name="proxyName"></param>
    /// <returns></returns>
    //
    IProxy RetrieveProxy(string proxyName);
}
