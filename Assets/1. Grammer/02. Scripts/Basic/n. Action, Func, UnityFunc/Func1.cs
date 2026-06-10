using System;
using UnityEngine;

public class Func1 : MonoBehaviour
{
    // Action : 매개변수는 있지만 반환타입이 없는 델리게이트
    // Func : 매개변수와 반환타입이 모두 있는 델리게이트
    // 반환값 필요 -> Func 사용, 반환값 필요없음 -> Action 사용

    Func<int> func;
    // Func<in, out>
    // Func<in, in, out>
    Func<int, int> func2; // 매개변수 1개, 반환타입 int
    

    void Start()
    {
        func = () =>
        { 
            int num2 = 3;
            Debug.Log("Func : " + num2);
            return num2;
        };

        func += () =>
        {
            Debug.Log(int.MinValue);
            return int.MinValue;
        };

        int num1 = func.Invoke();
    }
}
