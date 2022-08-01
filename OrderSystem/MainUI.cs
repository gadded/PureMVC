using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ApplicationFacade facade = new ApplicationFacade();
        facade.StartUp(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
