using System;
using UnityEngine;

public class EventTestArgs : EventArgs
{
    private EventHandler eventHandler;

    public event EventHandler EventHandler
    {
        add
        {
            Debug.Log("이벤트 구독: " + value.Method.Name);
            eventHandler += value;
        }
        remove
        {
            Debug.Log("이벤트 구독 해제: " + value.Method.Name);
            eventHandler -= value;
        }
    }

    public void InvokeEvent()
    {
        eventHandler?.Invoke(this, EventArgs.Empty);
    }
}

public class DelegateTest13 : MonoBehaviour
{
    void Start()
    {
        EventTestArgs eventTestArgs = new EventTestArgs();

        // 이벤트 구독
        eventTestArgs.EventHandler += Test1;
        // 이벤트 발생
        eventTestArgs.InvokeEvent();
    }

    void Test1(object o, EventArgs e)
    {
        Debug.Log("Test1");
    }
}
