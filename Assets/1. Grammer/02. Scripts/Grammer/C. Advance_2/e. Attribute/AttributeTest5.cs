using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

// AttributeUsage : Attribute를 적용할 수 있는 대상(메서드, 클래스)과 사용 규칙을 정의
[AttributeUsage(AttributeTargets.Field)]
public class FindComponentsAttribute : Attribute
{
    public string[] goNames { get; }
    
    // params : 메서드가 정해지지 않은 개수의 인수를 받을 수 있음.
    //          배열타입 앞에 사용되며, 이를 통해 여러 개의 값을 배열로 처리할 수 있음
    public FindComponentsAttribute(params string[] _goNames)
    {
        goNames = _goNames;
    }
}

public class AttributeTest5 : MonoBehaviour
{
    [FindComponents("Target1")]public Rigidbody rb;
    [FindComponents("Target1")]public BoxCollider bc;
    [FindComponents("Target2")]public AudioSource audi;
    [FindComponents("Target3", "Target4")] public AudioSource[] audiArr = new AudioSource[2];

    private void Awake()
    {
        Util.InjectComponent2(this);
    }
}
