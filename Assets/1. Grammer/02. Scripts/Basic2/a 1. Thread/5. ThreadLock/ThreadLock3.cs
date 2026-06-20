using System.Threading;
using UnityEngine;

public class ThreadLock3 : MonoBehaviour
{
    // 스레드 동기화 : 여러 스레드가 공유 자원에 접근할 때 발생하는 문제를 해결하는 방식
    Thread t1, t2;

    int num;

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

    // Interlocked 클래스는 "원자적 연산(atomic operation)" 방식으로 작동
    // : 하나의 스레드가 연산 상태에 들어갔을 때,
    //   그 연산은 더는 나뉠 수 없는 단일 연산으로 취급하는 방식으로
    //   다른 스레드가 중간에 개입할 수 없다.
    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
            Interlocked.Increment(ref num);
    }
}
