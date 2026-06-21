using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Task task = new Task(SleepAction);
        // ContinueWith() : Task가 완료된 후 실행할 작업(Task) 지정
        task.ContinueWith((obj) =>
        {
            Debug.Log("Task 완료");
        });

        // Run() : Task의 생성과 시작을 동시에
        // WhenAll() : 매개변수 Task가 모두 완료될 때까지 대기
        //             모든 Task가 완료되면 새로운 Task 반환
        // WhenAny() : 매개변수 Task 중 먼저 완료된 Task 반환
        // Task.Factory.StartNew() : Run() 메소드보다 좀 더 많은 옵션을 선택 가능

        task.Start();
    }

    void SleepAction()
    {
        Thread.Sleep(3000);
    }
}
