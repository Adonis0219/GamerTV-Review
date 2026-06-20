using System.Threading;
using UnityEngine;

public class ThreadPool1 : MonoBehaviour
{
    // 프로그래밍에서 풀(Pool)은 재사용할 수 있는 자원의 집합
    // 스레드풀은 필요할 때 재사용해서 꺼내 쓰고 필요 없어지면 풀에 반환되는 기능

    // 스레드 풀

    // 스레드 풀 사용 이유

    // 스레드 동작 방식
    // 1) 상시 실행 스레드
    //    스레드가 생성되면 비교적 오랜 시간동안 생성돼 있는 방식, 무한 루프가 많음
    // 2) 일회성 임시 실행
    //    특수 연산만을 수행하고 바로 종료하는 방식의 스레드

    void Start()
    {
        // 새로운 스레드 생성이 없다

        ThreadPool.QueueUserWorkItem(TestThreadPool);

        // Thread.Start() 메소드가 없다
    }

    void TestThreadPool(object value)
    {
        Debug.Log("스레드 풀 시작");
    }
}
