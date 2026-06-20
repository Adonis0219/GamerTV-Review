using System.Threading;
using UnityEngine;

public class ThreadLock5 : MonoBehaviour
{
    private readonly object locker = new object();

    // 아래의 코드는 데드락 상태가 된다.
    // 데드락(Deadlock) : 둘 이상의 프로세스나 스레드가 서로 상호작용을 기다리면서 무한히 기다리는 상태를 말함
    private void Start()
    {
        Thread pingThread = new Thread(Ping);
        Thread pongThread = new Thread(Pong);

        pingThread.Start();
        pongThread.Start();
    }

    // 데드락 방지 -> ThreadLock6.cs
    void Ping()
    {
        lock (locker)
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor.Wait(locker);   // 대기 및 lock 해제
                Debug.Log("Ping");
                Monitor.Pulse(locker);  // 대기 중인 Pong 스레드에 신호 보내기
            }
        }
    }

    void Pong()
    {
        lock (locker)
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor.Wait(locker);   // 대기 및 lock 해제
                Debug.Log("Pong");
                Monitor.Pulse(locker);  // 대기 중인 Ping 스레드에 신호 보내기
            }
        }
    }
}
