using System;
using UnityEngine;

public class DelegateTest8 : MonoBehaviour
{
    private delegate void TestDelegate();   // 델리게이트 타입 정의

    private TestDelegate testDelegate;      // 델리게이트 변수 선언

    // 참조할 함수들...
    void Chain1() { Debug.Log("체인 1"); }
    void Chain2() { Debug.Log("체인 2"); }
    void Chain3() { Debug.Log("체인 3"); }

    void Start()
    {
        testDelegate = new TestDelegate(Chain1) 
                     + new TestDelegate(Chain2) 
                     + new TestDelegate(Chain3);   // 델리게이트 인스턴스 생성

        testDelegate.Invoke();   // 델리게이트 체인 호출 (체인 1, 체인 2, 체인 3 순서로 출력)
    }
}
