using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : IFacade
{
    //protected   只能在本类和继承中使用  
    //volatile   特征修饰符  这变量可能会被意想不到地改变，这样编译器就不会去假设这个变量的值了。
    protected IController m_controller;//？？con的实体
    protected IModel m_model;
    protected IView m_view;
    protected static volatile IFacade m_instance;
    protected static readonly object m_staticSyncRoot = new object();

    //添加构造函数
    protected Facade()
    {
        //走初始化MVC的方法
        this.InitializeFacade();
    }

    protected virtual void InitializeFacade()
    {
        this.InitializeModel();
        this.InitializeController();
        this.InitializeView();
    }

    protected virtual void InitializeController()
    {
        if (this.m_controller == null)
        {
            this.m_controller = Controller.Get;
        }
    }

    protected virtual void InitializeView()
    {
        if (this.m_view == null)
        {
            this.m_view = View.Instance;
        }
    }

    protected virtual void InitializeModel()
    {
        if (this.m_model == null)
        {
            this.m_model = Model.Get;
        }
    }

    public bool HasCommand(string notificationName)
    {
        return this.m_controller.HasCommand(notificationName);
    }

    public bool HasMediator(string mediatorName)
    {
        return this.m_view.HasMediator(mediatorName);
    }

    public bool HasProxy(string proxyName)
    {
        return this.m_model.HasProxy(proxyName);
    }

    public void NotifyObservers(INotification note)
    {
        this.m_view.NotifyObservers(note);
    }

    public void RegisterCommand(string notificationName, Type commandType)
    {
        this.m_controller.RegisterCommand(notificationName, commandType);
    }

    public void RegisterMediator(IMediator mediator)
    {
        this.m_view.RegisterMediator(mediator);
    }

    public void RegisterProxy(IProxy proxy)
    {
        this.m_model.RegisterProxy(proxy);
    }

    public void RemoveCommand(string notificationName)
    {
        this.m_controller.RemoveCommand(notificationName);
    }

    public IMediator RemoveMediator(string mediatorName)
    {
        return this.m_view.RemoveMediator(mediatorName);
    }

    public IProxy RemoveProxy(string proxyName)
    {
        return this.m_model.RemoveProxy(proxyName);
    }

    public IMediator RetrieveMediator(string mediatorName)
    {
        return this.m_view.RetrieveMediator(mediatorName);
    }

    public IProxy RetrieveProxy(string proxyName)
    {
        return this.m_model.RetrieveProxy(proxyName);
    }

    public void SendNotification(string notificationName)
    {
        this.NotifyObservers(new Notification(notificationName));
    }

    public void SendNotification(string notificationName, object body)
    {
        this.NotifyObservers(new Notification(notificationName, body));
    }

    public void SendNotification(string notificationName, object body, string type)
    {
        this.NotifyObservers(new Notification(notificationName, body, type));
    }

    /// <summary>
    /// 单例形式，执行构造，走父类的构造函数
    /// </summary>
    public static IFacade Get
    {
        get
        {
            if (m_instance == null)
            {
                lock (m_staticSyncRoot)
                {
                    if (m_instance == null)
                    {
                        m_instance = new Facade();
                    }
                }
            }
            return m_instance;
        }
    }
}
