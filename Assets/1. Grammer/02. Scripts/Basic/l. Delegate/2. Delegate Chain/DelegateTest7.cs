using System;
using UnityEngine;

public class DelegateTest7 : MonoBehaviour
{
    // 델리게이트 체인 (Delegate Chain) : 하나의 델리게이트가 여러 메서드를 참조 가능
    // 여러 개의 메서드를 하나의 델리게이트로 연결하여 호출하는 방식

    private delegate void TestDelegate();   // 델리게이트 타입 정의

    private TestDelegate testDelegate;      // 델리게이트 변수 선언

    // 참조할 함수들...
    void Chain1() { Debug.Log("체인 1"); }
    void Chain2() { Debug.Log("체인 2"); }
    void Chain3() { Debug.Log("체인 3"); }

    void Start()
    {
        // 이전 버전
        TestDelegate test1 = new TestDelegate(Chain1);   // 델리게이트 인스턴스 생성
        TestDelegate test2 = new TestDelegate(Chain2);
        TestDelegate test3 = new TestDelegate(Chain3);

        testDelegate = Delegate.Combine(test1, test2, test3) as TestDelegate;   // 델리게이트 체인 생성

        testDelegate.Invoke();   // 델리게이트 체인 호출 (체인 1, 체인 2, 체인 3 순서로 출력)
    }
}
