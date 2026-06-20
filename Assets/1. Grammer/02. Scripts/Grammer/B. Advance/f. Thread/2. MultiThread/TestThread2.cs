using UnityEngine;
using System.Threading; // 스레드를 사용하기 위해 선언

public class TestThread2 : MonoBehaviour
{
    Thread thread;

    void Start()
    {
        thread = new Thread(new ThreadStart(Temp));
        thread = new Thread(Temp);  // 축약도 가능
        thread.Start();
    }

    void Temp()
    {
        Debug.Log("스레드 시작");
        Debug.Log(thread.ThreadState);
        // 현재 실행 중인 스레드를 지정한 시간(밀리초)만큼 일시적으로 중지
        Thread.Sleep(2000);     // 2초 동안 스레드 중지
        Debug.Log("스레드 종료");
    }
}
