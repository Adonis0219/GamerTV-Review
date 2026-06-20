using System.Threading;
using UnityEngine;

public class ThreadLock1 : MonoBehaviour
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
        // 실행결과는 20000이 안 됨 ->
        // 레이스 컨디션(Race Condition) : 두 개 이상의 스레드가 공유된 자원에 동시에 접근하려고 할 때 발생하는 문제

        // 방지를 위해 스레드 동기화를 해줌
        // C#에서는 대표적으로 lock 키워드를 사용 -> ThreadLock2.cs 참조
    }

    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
            num++;
    }
}
