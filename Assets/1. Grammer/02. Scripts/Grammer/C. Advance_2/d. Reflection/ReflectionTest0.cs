using System;
using System.Reflection;
using UnityEngine;

public class ReflectionTest0 : MonoBehaviour
{
    void Start()
    {
        int a = 0;

        Type type = a.GetType();
        FieldInfo[] fields = type.GetFields();

        foreach (FieldInfo field in fields)
        {
            Debug.Log($"Field Name: {field.Name}, Field Type: {field.FieldType}");
        }
    }
}
