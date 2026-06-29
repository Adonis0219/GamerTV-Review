using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ThreadPool.QueueUserWorkItem((obj) =>
        {
            Debug.Log("스레드풀 실행");
        });

        Task task = new Task(() =>
        {
            Debug.Log("테스크 실행");
        });

        task.Start();
        task.Wait(); // : Thread.Join()과 비슷한 기능
    }
}
