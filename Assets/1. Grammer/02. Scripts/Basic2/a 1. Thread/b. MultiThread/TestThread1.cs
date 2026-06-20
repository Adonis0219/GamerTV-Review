using UnityEngine;
using System.Threading; // 스레드를 사용하기 위해 선언

public class TestThread1 : MonoBehaviour
{
    void Start()
    {
        // 현재 스레드 상태를 확인
        Thread thread = Thread.CurrentThread;
        Debug.Log(thread.ThreadState);
    }
}
