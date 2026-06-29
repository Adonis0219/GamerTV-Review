using UnityEngine;

public class Lamda6 : MonoBehaviour
{
    delegate void TestDelegate();
    
    // 람다식의 단점
    // delegate chain 관리가 어려움
    // 람다식은 익명 메서드이므로, 델리게이트 체인에서 특정 람다식을 제거하는 것이 어렵습니다.
    void Start()
    {
        TestDelegate testDelegate;
        testDelegate = () => Debug.Log("Hello, Lambda!");
        testDelegate += () => Debug.Log("Welcome to C# programming.");
        testDelegate -= () => Debug.Log("Hello, Lambda!");

        testDelegate.Invoke();
    }
}
