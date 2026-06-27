using UnityEngine;

public class AsyncAwait1 : MonoBehaviour
{
    // 동기(Synchronous) : 각 직업이 순차적으로 일어나는 방식

    // async await
    // C# 5.0부터 지원

    private void Start()
    {
        Test1();
        Test2();
        Test3();
    }

    void Test1() => Debug.Log("Test1");
    void Test2() => Debug.Log("Test1");
    void Test3() => Debug.Log("Test1");
}
