using System;
using UnityEngine;

public class TestArgs : EventArgs
{
    public int value;

    public TestArgs(int value)
    {
        this.value = value;
    }
}

public class TestArgs2
{
    public string message;

    public TestArgs2(string message)
    {
        this.message = message;
    }
}

public class DelegateTest12 : MonoBehaviour
{
    // 이벤트 핸들러 : 미리 선언된 델리게이트, 이벤트 용도
    public event EventHandler eventHandler;

    public event EventHandler<TestArgs2> eventHandlerWithArgs;

    void Start()
    {
        TestArgs args = new TestArgs(10);
        TestArgs2 args2 = new TestArgs2("Hello, World!");

        // 이벤트 구독
        eventHandler += Test;

        // 이벤트 발생
        eventHandler?.Invoke(this, (TestArgs)args);
    }

    void Test(object o, EventArgs e)
    {
        TestArgs testArgs = e as TestArgs;
        if (testArgs != null)
        {
            Debug.Log("Test: " + testArgs.value);
        }
    }
}
