using UnityEngine;
using System.Threading; // 스레드를 사용하기 위해 선언

public class TestThread3 : MonoBehaviour
{
    Thread thread;

    void Start()
    {
        // 인자를 여러개 받고 싶으면? -> TestThread4.cs 참조
        thread = new Thread(new ParameterizedThreadStart(Temp));
        thread = new Thread(Temp);  // 축약도 가능
        thread.Start(10);
    }

    void Temp(object num)
    {
        Debug.Log("스레드 시작");
        Debug.Log(thread.ThreadState);
        // 현재 실행 중인 스레드를 지정한 시간(밀리초)만큼 일시적으로 중지
        Thread.Sleep(2000);     // 2초 동안 스레드 중지
        Debug.Log(num);
        Debug.Log("스레드 종료");
    }
}
