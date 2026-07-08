using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

public static class Util
{
    /// <summary>
    /// 게임오브젝트의 Transform을 찾는 재귀 함수
    /// </summary>
    /// <param name="name">타겟 이름</param>
    /// <param name="tr">시작 위치</param>
    /// <returns>찾은 Transform</returns>
    public static Transform FindChild(string name, Transform tr)
    {
        if (tr.name == name) 
            return tr;

        for (int i = 0; i < tr.childCount; i++)
        {
            Transform findTr = FindChild(name, tr.GetChild(i));

            if (findTr != null) 
                return findTr;
        }

        return null;
    }

    public static void InjectComponent(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var one in fields)
        {
            var attribute = (FindComponentAttribute)one.GetCustomAttribute(typeof(FindComponentAttribute));

            if (attribute == null)
            {
                Debug.Log($"필드 '{one.Name}'에 대한 FindComponentAttribute가 없습니다.");
                continue;
            }

            Type filedType = one.FieldType;
            Transform tr = FindChild(attribute.goName, script.transform);

            if (tr = null)
            {
                Debug.Log($"게임오브젝트 '{attribute.goName}'의 Transform을 찾지 못했습니다.");
                continue;
            }

            Component component = tr.GetComponent(filedType);

            if (component == null)
            {
                Debug.Log($"게임오브젝트 '{attribute.goName}'에서 '{filedType}' 컴포넌트를 찾지 못했습니다.");
                continue;
            }

            one.SetValue(script, component);
        }
    }

    public static void InjectComponent2(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var one in fields)
        {
            var attribute = (FindComponentsAttribute)one.GetCustomAttribute(typeof(FindComponentsAttribute));

            if (attribute == null)
            {
                Debug.Log($"필드 '{one.Name}'에 대한 FindComponentAttribute가 없습니다.");
                continue;
            }

            Type filedType = one.FieldType;

            // 필드가 배열인 경우 처리
            if (filedType.IsArray)
            {
                // 배열 요소 타입 가져오기 (예 : Rigidbody[])
                Type elementType = filedType.GetElementType();

                List<Component> componentsList = new List<Component>();

                foreach (string goName in attribute.goNames)
                {
                    Transform tr = FindChild(goName, script.transform);

                    if (tr = null)
                    {
                        Debug.Log($"게임오브젝트 '{goName}'의 Transform을 찾지 못했습니다.");
                        continue;
                    }

                    Component component = tr.GetComponent(filedType);

                    if (component == null)
                    {
                        Debug.Log($"게임오브젝트 '{goName}'에서 '{filedType}' 컴포넌트를 찾지 못했습니다.");
                        continue;
                    }

                    componentsList.Add(component);
                }

                Array compoArr = Array.CreateInstance(elementType, componentsList.Count);

                for (int i = 0; i < componentsList.Count; i++)
                {
                    compoArr.SetValue(componentsList[i], i);
                }

                one.SetValue(script, compoArr);
            }
            else
            {
                // 단일 컴포넌트 처리
                Transform tr = FindChild(attribute.goNames[0], script.transform);

                if (tr = null)
                {
                    Debug.Log($"게임오브젝트 '{attribute.goNames[0]}'의 Transform을 찾지 못했습니다.");
                    continue;
                }

                Component component = tr.GetComponent(filedType);

                if (component == null)
                {
                    Debug.Log($"게임오브젝트 '{attribute.goNames[0]}'에서 '{filedType}' 컴포넌트를 찾지 못했습니다.");
                    continue;
                }

                one.SetValue(script, component);
            }
        }
    }

    public static void InjectComponent3(object o)
    {
        Type type = o.GetType();
        MonoBehaviour script = o as MonoBehaviour;

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var one in fields)
        {
            var attribute = (FindComponentsAttribute)one.GetCustomAttribute(typeof(FindComponentsAttribute));

            if (attribute == null)
            {
                Debug.Log($"필드 '{one.Name}'에 대한 FindComponentAttribute가 없습니다.");
                continue;
            }

            Type filedType = one.FieldType;

            // 필드가 배열인 경우 처리
            if (filedType.IsArray)
            {
                // 배열 요소 타입 가져오기 (예 : Rigidbody[])
                Type elementType = filedType.GetElementType();

                List<Component> componentsList = new List<Component>();

                foreach (string goName in attribute.goNames)
                {
                    Transform tr = FindChild(goName, script.transform);

                    if (tr = null)
                    {
                        Debug.Log($"게임오브젝트 '{goName}'의 Transform을 찾지 못했습니다.");
                        continue;
                    }

                    Component component = tr.GetComponent(filedType);

                    if (component == null)
                    {
                        Debug.Log($"게임오브젝트 '{goName}'에서 '{filedType}' 컴포넌트를 찾지 못했습니다.");
                        continue;
                    }

                    componentsList.Add(component);
                }

                Array compoArr = Array.CreateInstance(elementType, componentsList.Count);

                for (int i = 0; i < componentsList.Count; i++)
                {
                    compoArr.SetValue(componentsList[i], i);
                }

                one.SetValue(script, compoArr);
            }
            else
            {
                // 단일 컴포넌트 처리
                Transform tr = FindChild(attribute.goNames[0], script.transform);

                if (tr = null)
                {
                    Debug.Log($"게임오브젝트 '{attribute.goNames[0]}'의 Transform을 찾지 못했습니다.");
                    continue;
                }

                Component component = tr.GetComponent(filedType);

                if (component == null)
                {
                    Debug.Log($"게임오브젝트 '{attribute.goNames[0]}'에서 '{filedType}' 컴포넌트를 찾지 못했습니다.");
                    continue;
                }

                one.SetValue(script, component);
            }
        }
    }
}
