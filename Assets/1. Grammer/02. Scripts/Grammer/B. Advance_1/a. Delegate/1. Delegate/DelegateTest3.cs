using UnityEngine;

public class DelegateTest3 : MonoBehaviour
{
    public delegate void TestDelegate();    // 델리게이트 타입 선언

    TestDelegate _testDelegate;    // 델리게이트 변수 선언(객체 정의)

    void Start()
    {
        _testDelegate = TargetF;   // 델리게이트 변수에 함수 대입

        Do(_testDelegate);    // 델리게이트를 매개변수로 전달
    }

    // 델리게이트는 '타입'이기 때문에 매개변수로 전달할 수 있다.
    void Do(TestDelegate del)   // 델리게이트를 매개변수로 받는 함수
    {
        del();  // 매개변수로 받은 델리게이트 호출
        del.Invoke();   // 매개변수로 받은 델리게이트 호출
    }

    void TargetF()
    {
        // 여기 있는 코드 사용하고 싶음
        Debug.Log("TargetF");
    }
}
