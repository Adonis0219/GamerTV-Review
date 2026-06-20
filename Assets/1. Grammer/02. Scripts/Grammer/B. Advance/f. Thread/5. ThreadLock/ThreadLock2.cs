using System.Threading;
using UnityEngine;

public class ThreadLock2 : MonoBehaviour
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

    // lock 키워드로 감싼 부분은
    // 크리티걸 섹션(Critical Section) : 한 번에 한 스레드만 사용할 수 있는 코드 영역
    // 간단한 연산은 lock 키워드 없이 사용 가능 -> ThreadLock3.cs 참조

    // lock 키워드의 내부적 작동 방식 -> ThreadLock4.cs 참조
    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
            lock (_lock)
                num++;
    }
}
