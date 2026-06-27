using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwait4 : MonoBehaviour
{
    // 비동기 (Asynchronous)
    // 프로그램이 병렬적으로 실행되도록 하여 작업을 효율적으로 처리할 수 있게 해준다
    // 주로 I/O 작업(파일 읽기/쓰기, 네트워크 통신)에 사용

    // C# 1.0에서 비동기 실행 방법은
    // BeginInvoke와 EndInvoke 메서드로 만들 수 있었다

    private void Start()
    {
        Action action = LogRunningOP;
        IAsyncResult result = action.BeginInvoke(new AsyncCallback(EndOPCB), null);
        Debug.Log("메인스레드 진행 중");
    }

    void LogRunningOP()
    {
        // 오래 걸리는 작업 (3초 지연)
        Thread.Sleep(3000);
        Debug.Log("오래 걸리는 작업");
    }

    void EndOPCB(IAsyncResult asyncResult)
    {
        Debug.Log("콜백 실행");
    }
}
