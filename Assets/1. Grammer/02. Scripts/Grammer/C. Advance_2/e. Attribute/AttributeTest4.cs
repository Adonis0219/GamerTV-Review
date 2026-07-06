using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

// AttributeUsage : Attribute를 적용할 수 있는 대상(메서드, 클래스)과 사용 규칙을 정의
[AttributeUsage(AttributeTargets.Field)]
public class FindComponentAttribute : Attribute
{
    public string goName { get; }

    public FindComponentAttribute(string _goName)
    {
        goName = _goName;
    }
}

public class AttributeTest4 : MonoBehaviour
{
    [FindComponent("Target1")]public Rigidbody rb;
    [FindComponent("Target1")]public BoxCollider bc;
    [FindComponent("Target2")]public AudioSource audi;

    private void Awake()
    {
        Util.InjectComponent(this);
    }
}
