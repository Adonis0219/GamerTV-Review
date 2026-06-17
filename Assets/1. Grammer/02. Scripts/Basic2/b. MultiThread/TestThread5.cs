using System.Threading;
using UnityEngine;

public class TestThread5 : MonoBehaviour
{
    Thread thread1, thread2;

    void Start()
    {
        thread1 = new Thread(Thread1Function);
        thread1.Start();
    }

    void Thread1Function()
    {
        Debug.Log("스레드 1 시작");
        thread2 = new Thread(Thread2Function);
        thread2.Start();
        // 현재 스레드가 다른 스레드의 작업이 완료될 때까지 대기하도록 만듦
        thread2.Join();
        Debug.Log("조인 완료");
    }

    void Thread2Function()
    {
        Debug.Log("스레드 2 시작");
        Thread.Sleep(2000); // 2초 동안 스레드 대기
        Debug.Log("스레드 2 끝");
    }

    // 예상 로그
    // 1 시작 -> 2 시작 -> 조인 완료 -> 2 끝

    // 실제 로그
    // 1 시작 -> 2 시작 -> 2 끝 -> 조인 완료
}
