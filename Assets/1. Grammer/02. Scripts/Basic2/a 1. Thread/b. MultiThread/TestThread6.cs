using System.Threading;
using UnityEngine;

public class TestThread6 : MonoBehaviour
{
    Thread thread1;

    void Start()
    {
        // 새로운 스레드 생성 및 시작
        thread1 = new Thread(ThreadFunction);
        thread1.Start();
    }

    void ThreadFunction()
    {
        try // 예외가 발생할 수 있는 구문
        {
            Debug.Log("스레드 시작");
            Thread.Sleep(5000); // 5초 대기
            Debug.Log("스레드 종료");
        }
        catch (ThreadAbortException)    // 예외 발생 시 실행할 구문 1
        {
            Debug.Log("스레드 강제 종료됨");
        }
        catch (ThreadInterruptedException) // 예외 발생 시 실행할 구문 2
        {
            Debug.Log("스레드 WaitSleepJoin");
        }
    }

    private void Update()
    {
        // 일정 시간이 지난 후 스레드를 강제 종료
        if (Time.timeSinceLevelLoad > 2f)   // 예시로 2초 후 종료
        {
            // ThreadAbortException 예외를 발생시키고 스레드 강제 종료 -> 굉장히 위험한 작업이기 때문에 사용 X
            thread1.Abort();    // 하자마자 종료
            // ThreadInterruptedException 예외를 발생시키고 스레드를 종료
            thread1.Interrupt();    // WaitSleepJoin 상태가 될 때까지 기다렸다가 종료
        }
    }
}
