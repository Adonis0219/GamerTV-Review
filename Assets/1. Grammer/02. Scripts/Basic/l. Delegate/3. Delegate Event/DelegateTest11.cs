using System;
using UnityEngine;

public class DelegateTest11 : MonoBehaviour
{
    // 이벤트 핸들러 : 미리 선언된 델리게이트, 이벤트 용도
    public event EventHandler eventHandler;

    void Start()
    {
        // 이벤트 구독
        eventHandler += Test;

        // 이벤트 발생
        eventHandler?.Invoke(this, EventArgs.Empty);
    }

    // 이벤트 핸들러와 시그니처 일치
    /// <summary>
    /// 이벤트 핸들러는 object와 EventArgs를 매개변수로 받는 메서드여야 합니다.
    /// </summary>
    /// <param name="o">이벤트를 발생시킨 객체</param>
    /// <param name="e">이벤트 데이터(전달하고 싶은 정보가 있을 때 사용)</param>
    void Test(object o, EventArgs e)
    {
        Debug.Log("Test");
    }
}
