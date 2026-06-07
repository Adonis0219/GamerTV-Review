using UnityEngine;

// 델리게이트 event : 객체의 상태 변화나 사건의 발생을 알리는 용도
public class TestDelegate
{
    public delegate void TestEvent();
    
    public event TestEvent onTestEvent; // 이벤트 선언

    public void TriggerEvent()
    {
        onTestEvent?.Invoke(); // 이벤트 발생 (구독된 메서드 호출)
    }
}

public class DelegateTest10 : MonoBehaviour
{
    private void Start()
    {
        TestDelegate testDelegate = new TestDelegate();
        
        testDelegate.onTestEvent += Test1; // 이벤트에 메서드 구독
        testDelegate.onTestEvent += Test2;
        testDelegate.onTestEvent += Test3;

        // delegate event는 외부에서 직접 호출할 수 없다.
        // testDelegate.onTestEvent?.Invoke(); // 이벤트 발생 (구독된 메서드 호출)

        // 이벤트 발생을 위해서는 TriggerEvent 메서드를 호출해야 한다. (간접 호출)
        testDelegate.TriggerEvent();

        // delegate event는 외부에서 직접 할당(대입 연산자)할 수 없다. (대입(=) 연산자 사용 불가능)
        // testDelegate.onTestEvent = Test2;   // 이벤트에 새로운 메서드 할당 (기존 구독 제거)
    }

    public void Test1() { Debug.Log("Test1"); }
    public void Test2() { Debug.Log("Test2"); } 
    public void Test3() { Debug.Log("Test3"); }
}
