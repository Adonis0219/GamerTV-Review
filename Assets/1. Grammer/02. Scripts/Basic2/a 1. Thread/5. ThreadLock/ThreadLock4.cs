using System.Threading;
using UnityEngine;

public class ThreadLock4 : MonoBehaviour
{
    // 스레드 동기화 : 여러 스레드가 공유 자원에 접근할 때 발생하는 문제를 해결하는 방식
    Thread t1, t2;

    int num;

    // _lock의 타입은 참조형이라면 뭐든지 가능 -> 일반적으로 object로 선언
    // lock 키워드의 매개변수로 this, Type 형식, string 형식은 피하는 게 좋음
    private readonly object _lock = new object();   // 동일한 잠금 객체

    void Start()
    {
        num = 0;
        t1 = new Thread(TestFunction);
        t2 = new Thread(TestFunction);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Debug.Log(num); // 20000
    }

    // 하지만 주로 lock 키워드만 사용
    // Monitor 클래스는 조금 더 섬세한 동기화가 필요할 때 -> ThreadLock5.cs
    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
        {
            Monitor.Enter(_lock);

            try
            {
                num++;
            }
            // 예외 발생 여부와 상관없이 항상 실행되어야 하는 코드를 작성.
            // 주로 리소스 해제 정리에 사용
            finally
            {
                Monitor.Exit(_lock);
            }
        }

    }
}
