using System.Threading;
using UnityEngine;

public class ThreadState1 : MonoBehaviour
{
    // 스레드 실행 순서 코드
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(TestThread);
            thread.Start(i);
        }
    }
    // 예상 : 0, 1, 2, 3, 4 ..... 번째 스레드
    // 실제 : 순서 뒤죽박죽 -> 운영체제가 우선순위에 따라서 스레드를 실행시키기 때문

    void TestThread(object num)
    {
        Debug.Log($"{num} 번째 스레드");
    }
}
