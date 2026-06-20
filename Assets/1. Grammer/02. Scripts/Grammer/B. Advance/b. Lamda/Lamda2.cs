using UnityEngine;

public class Lamda2 : MonoBehaviour
{
    delegate void TestDelegate();

    private void Start()
    {
        TestDelegate test;
        // 익명 메서드로 일회성 사용 -> 람다식으로 표현 가능 => Lamda2_1.cs
        test = delegate()
        {
            Debug.Log("TestFunc");
        };

        test.Invoke();
    }
}
