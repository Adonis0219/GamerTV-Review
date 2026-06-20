using UnityEngine;

public class Lamda4_1 : MonoBehaviour
{
    delegate int TestDelegate(int num1, int num2);

    private void Start()
    {
        TestDelegate test;
        test = (int n1, int n2) => n1 + n2;
        // 메서드 유추 가능 (타입을 적지 않아도 됨)
        test = (n1, n2) => n1 + n2;
        // 람다문 형식으로 여러 줄 작성 가능
        test = (n1, n2) =>
        {
            Debug.Log("Calculating sum...");
            return n1 + n2;
        };

        int result = test.Invoke(5, 10);
        Debug.Log("Result: " + result);
    }
}
