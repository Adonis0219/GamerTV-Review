using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Task task = new Task(SleepAction);
        task.Start();
        task.Wait();    // Task가 완료될 때까지 현재 스레드 대기
        Debug.Log("Task 완료");
    }

    void SleepAction()
    {
        Thread.Sleep(3000);
    }
}
