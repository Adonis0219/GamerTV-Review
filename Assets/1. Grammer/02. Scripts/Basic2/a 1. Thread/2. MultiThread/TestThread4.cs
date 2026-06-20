using UnityEngine;
using System.Threading; // 스레드를 사용하기 위해 선언

public class TestThread4 : MonoBehaviour
{
    public class Param
    {
        public Param(int _v1, int _v2)
        {
            value1 = _v1; 
            value2 = _v2;
        }

        public int value1, value2;
    }

    Thread thread;

    void Start()
    {
        thread = new Thread(Temp);
        Param param = new Param(10, 20);
        thread.Start(param);
    }

    void Temp(object obj)
    {
        Debug.Log("스레드 시작");
        Debug.Log(thread.ThreadState);
        // 현재 실행 중인 스레드를 지정한 시간(밀리초)만큼 일시적으로 중지
        Thread.Sleep(2000);     // 2초 동안 스레드 중지
        Param param = (Param)obj;
        Debug.Log(param.value1);
        Debug.Log(param.value2);
        Debug.Log("스레드 종료");
    }
}
