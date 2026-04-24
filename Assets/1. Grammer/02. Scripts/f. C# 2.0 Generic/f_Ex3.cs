using System.Collections.Generic;
using UnityEngine;

public class f_Ex3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ArrayList의 제네릭 버전인 List<T> 클래스입니다.
        List<int> list = new List<int>();

        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        // 10, 20, 30, 40, 50

        list.RemoveAt(0);
        // 20, 30, 40, 50

        list.Remove(40);
        // 20, 30, 50

        list.Insert(1, 25);
        // 20, 25, 30, 50

        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]);
    }
}
