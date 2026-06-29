using System;
using UnityEngine;

public class DelegateTest9 : MonoBehaviour
{
    private delegate void TestDelegate();   // 델리게이트 타입 정의

    private TestDelegate testDelegate;      // 델리게이트 변수 선언

    // 참조할 함수들...
    void Chain1() { Debug.Log("체인 1"); }
    void Chain2() { Debug.Log("체인 2"); }
    void Chain3() { Debug.Log("체인 3"); }

    void Start()
    {
        // C# 2.0 버전
        testDelegate += Chain1;
        testDelegate += Chain2;
        testDelegate += Chain3;

        testDelegate.Invoke();   // 델리게이트 체인 호출 (체인 1, 체인 2, 체인 3 순서로 출력)

        testDelegate -= Chain2;   // 체인 2 제거
        
        testDelegate.Invoke();   // 델리게이트 체인 호출 (체인 1, 체인 3 순서로 출력)
    }
}
