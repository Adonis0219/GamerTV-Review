using UnityEngine;

public class Example : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 비트 시프트 연산자
        int num = 8 << 2;   // 32
        Debug.Log(num);
        int num2 = 8 >> 2;  // 2
    }
}
