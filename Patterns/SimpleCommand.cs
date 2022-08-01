using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ºÚµ•÷∏¡Ó
/// </summary>
public class SimpleCommand : Notifier,ICommand,INotifier
{
    public virtual void Execute(INotification notification)
    {

    }
}
