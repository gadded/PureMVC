using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationFacade : Facade
{
    public new static IFacade Get
    {
        get
        {
            if (m_instance == null)
            {
                lock (m_staticSyncRoot)
                {
                    if (m_instance == null)
                    {
                        Debug.Log("构造函数，进入Facade的构造函数中，在构造函数中去实例MVC");
                        m_instance = new ApplicationFacade();
                    }
                }
            }
            return m_instance;
        }
    }

    public void StartUp(MainUI mainUI)
    {
        Debug.Log("游戏启动");
        SendNotification(OrderSystemEvent.STARTUP, mainUI);
    }

    #region 重写核心类型的构造函数

    protected override void InitializeFacade()
    {
        base.InitializeFacade();
    }
    protected override void InitializeView()
    {
        base.InitializeView();
    }

    protected override void InitializeController()
    {
        base.InitializeController();
        RegisterCommand(OrderSystemEvent.STARTUP, typeof(StartUpCommand));
    }

    protected override void InitializeModel()
    {
        base.InitializeModel();
    }

    #endregion
}
