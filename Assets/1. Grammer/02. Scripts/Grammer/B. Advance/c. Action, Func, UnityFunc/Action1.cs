using System;
using UnityEngine;

public class Action1 : MonoBehaviour
{
    // Action : 매개변수는 있지만 반환값이 없는 델리게이트 -> 매번 델리게이트를 선언하는 것이 귀찮아 만들어진 것
    Action action;

    private void Start()
    {
        action = () => Debug.Log("Action 1");
        action += () => Debug.Log("Action 2");
        action += () => Debug.Log("Action 3");

        // 매개변수가 있는 메서드는 일반 action에 추가할 수 없다. -> Action<int>과 같이 매개변수의 타입을 명시해야 한다. => Action2.cs 참고
        // action += Test1;

        action.Invoke();
    }

    public void Test1(int num)
    {
        Debug.Log("Test1 : " + num);
    }
}
