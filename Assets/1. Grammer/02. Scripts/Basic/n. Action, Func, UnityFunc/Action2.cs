using System;
using UnityEngine;

public class Action2 : MonoBehaviour
{
    // Action<T> : Generic Delegate, 일반화 대리자 -> 매개변수를 사용할 수 있는 Action
    // 반환타입을 넣고 싶다면 Func<T>를 사용하면 된다 -> Func1.cs 참고
    Action<int> action1;
    Action<string, string, int> action2;

    void Start()
    {
        action1 = Test1;
        action2 = Test2;
    }

    public void Test1(int num)
    {
        Debug.Log("Test1 : " + num);
    }

    public void Test2(string str1, string str2, int num)
    {
        Debug.Log("Test2 : " + str1 + ", " + str2 + ", " + num);
    }
}
