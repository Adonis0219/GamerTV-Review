using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class Task1 : MonoBehaviour
{
    // Task 클래스(C# 4.0) : 스레드, 스레드풀의 단점을 개선한 클래스
    // using System.Threading.Tasks; 선언

    private void Start()
    {
        Task task = new Task(BackgroundTask);
        task.Start();
    }
    
    // Task는 백그라운드 스레드이며 스레드풀을 이용한다
    void BackgroundTask()
    {
        bool isBg = Thread.CurrentThread.IsBackground;
        Debug.Log($"백그라운드 스레드 : {isBg}");

        bool isThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
        Debug.Log($"스레드풀 : {isThreadPoolThread}");
    }
}
