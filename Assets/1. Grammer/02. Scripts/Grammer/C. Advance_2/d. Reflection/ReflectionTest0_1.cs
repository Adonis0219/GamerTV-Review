using System;
using System.Reflection;
using UnityEngine;

public class ReflectionTest0_1 : MonoBehaviour
{
    void Start()
    {
        int a = 0;

        Type t1 = a.GetType();      // 런타임 시점(인스턴스)
        Type t2 = typeof(int);      // 컴파일 시점(자료형)
        Type t3 = Type.GetType("System.Int32"); // 런타임 시점(자료형)

        Debug.Log($"t1: {t1}, t2: {t2}, t3: {t3}");
    }
}
