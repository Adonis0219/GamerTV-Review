using NUnit.Compatibility;
using System;
using UnityEngine;

public class d_Ex3 : MonoBehaviour
{
    class Orc { }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Orc orc = new Orc();
        // GetType() : 클래스를 선언하면 내부적으로 클래스 정보를 가지고 있는 Type이라는 인스턴스가 만들어진다. GetType()은 객체가 가지고 있는 Type 클래스를 반환하는 함수이다.
        Type type = orc.GetType();
        // Type type = typeof(Orc); // typeof() : 클래스의 이름을 통해서 Type 클래스를 반환하는 함수이다. GetType()과 typeof()는 같은 결과를 반환한다. -> 객체 생성을 하지 않아도 됨

        Debug.Log(type.FullName);
        Debug.Log(type.IsClass);
        Debug.Log(type.IsArray);
    }
}
