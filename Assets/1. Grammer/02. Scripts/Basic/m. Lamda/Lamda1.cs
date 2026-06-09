using UnityEngine;

// 람다식 : 무명 함수, 간결한 표현식, 일회성 사용 C# 3.0

// 익명메서드(anonymous method) : 이름 없는 메서드, 델리게이트와 함께 사용 C# 2.0
// 델리게이트에 전달되는 메소드가 일회성으로 필요할 때 사용
public class Lamda1 : MonoBehaviour
{
    delegate void TestDelegate();

    private void Start()
    {
        TestDelegate test;
        test = TestFunc;

        test.Invoke();
    }

    // 테스트 델리게이트에 일회성으로 사용됨 -> 람다식으로 표현 가능 => Lamda2.cs
    void TestFunc()
    {
        Debug.Log("TestFunc");
    }
}
