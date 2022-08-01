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
                        Debug.Log("���캯��������Facade�Ĺ��캯���У��ڹ��캯����ȥʵ��MVC");
                        m_instance = new ApplicationFacade();
                    }
                }
            }
            return m_instance;
        }
    }

    public void StartUp(MainUI mainUI)
    {
        Debug.Log("��Ϸ����");
        SendNotification(OrderSystemEvent.STARTUP, mainUI);
    }

    #region ��д�������͵Ĺ��캯��

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
