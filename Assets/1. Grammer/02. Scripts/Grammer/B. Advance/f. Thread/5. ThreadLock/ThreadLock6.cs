using System.Threading;
using UnityEngine;

public class ThreadLock6 : MonoBehaviour
{
    private readonly object locker = new object();
    private bool isPingTurn = true;

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
                while(!isPingTurn)
                    Monitor.Wait(locker); // ping 차례가 아닐 때 대기

                Debug.Log("Ping");
                isPingTurn = false;     // pong 차례로 변경
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
                while (isPingTurn)
                    Monitor.Wait(locker); // pong 차례가 아닐 때 대기

                Debug.Log("Pong");
                isPingTurn = true;      // ping 차례로 변경
                Monitor.Pulse(locker);  // 대기 중인 Ping 스레드에 신호 보내기
            }
        }
    }
}
