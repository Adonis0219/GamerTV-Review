using UnityEngine;

public class DelegateTest4 : MonoBehaviour
{
    public delegate void TestDelegate();    // 델리게이트 타입 선언

    TestDelegate _testDelegate;    // 델리게이트 변수 선언(객체 정의)

    void Start()
    {
        TestDelegate result = Do();    // 델리게이트를 반환받는 함수 호출

        result.Invoke();   // 반환받은 델리게이트 호출
    }

    // 델리게이트는 '타입'이기 때문에 반환할 수 있다.   
    TestDelegate Do()
    {
        return _testDelegate = TargetF;    // 델리게이트를 반환
    }

    void TargetF()
    {
        // 여기 있는 코드 사용하고 싶음
        Debug.Log("TargetF");
    }
}
