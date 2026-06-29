using UnityEngine;

public class Lamda4 : MonoBehaviour
{
    delegate int TestDelegate(int num1, int num2);

    private void Start()
    {
        // 람다식으로 표현 가능 => Lamda4_1.cs
        TestDelegate test;
        test = delegate(int n1, int n2)
        {
            return n1 + n2;
        };

        int result = test.Invoke(5, 10);
        Debug.Log("Result: " + result);
    }
}
