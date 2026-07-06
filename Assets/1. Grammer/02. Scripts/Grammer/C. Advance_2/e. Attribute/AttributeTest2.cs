using System;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

// CustomAttribute
// using System; 선언
// 만든 클래스에 Attribute 상속 받기
public class MyCustomAttribute : Attribute
{
    public string Desc {  get; set; }

    public MyCustomAttribute(string desc)
    {
        Desc = desc;
    }
}

public class MyTestClass
{
    // Attribute는 붙여도 안 붙여도 됨
    [MyCustom("테스트용 메서드입니다.")]
    public void TestMethod()
    {
        Debug.Log("테스트 메서드 실행");
    }
}

public class AttributeTest2 : MonoBehaviour
{
    private void Start()
    {
        Type myTestClass = typeof(MyTestClass);

        foreach (var one in myTestClass.GetMethods())
        {
            var attribute = (MyCustomAttribute)one.GetCustomAttribute(typeof(MyCustomAttribute));

            if (attribute != null)
            {
                Debug.Log(attribute.Desc);
                one.Invoke(Activator.CreateInstance(typeof(MyTestClass)), null);
            }
        }
    }
}
