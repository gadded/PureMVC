using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ֪ͨ�������̳���֪ͨ�����Ľӿ�
/// </summary>
public class Notification : INotification
{
    private object m_body;//��Ϣ��
    private string m_name;//��Ϣ����
    private string m_type;//��Ϣ����

    //���캯��
    public Notification(string name)
    {
        this.m_name = name;
    }
    public Notification(string name, object body)
    {
        this.m_name = name;
        this.m_body = body;
    }
    public Notification(string name, object body, string type)
    {
        this.m_name = name;
        this.m_body = body;
        this.m_type = type;
    }

    public override string ToString()
    {
        return ((("Notification Name: " + this.Name)));
    }

    public object Body { get { return this.m_body; } set { this.m_body = value; } }
    public string Name { get =>  this.m_name; set => this.m_name=value; }
    public string Type { get => this.m_type; set => this.m_type = value; }
}
