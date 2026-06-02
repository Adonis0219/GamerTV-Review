using UnityEngine;

public class DelegateTest1 : MonoBehaviour
{
    // 델리게이트 : 함수의 주소값을 가지고 대신 호출
    // 접근제한자 delegate 반환형식 식별자(매개변수);

    // 델리게이트 정의 방법 : 대신 호출할 함수의 형식(시그니처)을 확인
    // Signature : 반환형식과 매개변수의 형식과 개수 

    public delegate void MyDelegate();     // 델리게이트 타입 정의

    public MyDelegate _myDelegate;          // 델리게이트 변수 선언

    #region 2

    public delegate int MyDelegate2(int a, int b);     // 델리게이트 타입 정의

    public MyDelegate2 _myDelegate2;          // 델리게이트 변수 선언

    #endregion



    public void TestFunction()
    {
        Debug.Log("Test");
    }

    #region 2

    public int TestFunction2(int a, int b)
    {
        return a + b;
    }

    #endregion

    void Start()
    {
        // 델리게이트는 참조형 타입
        _myDelegate = new MyDelegate(TestFunction);    // C# 1.0 버전, 사용법 

        _myDelegate = TestFunction;    // C# 2.0 버전, 사용법

        _myDelegate();     // 델리게이트 호출
    }
}
