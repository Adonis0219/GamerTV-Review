using System;
using System.Reflection;
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
        }
    }
}
