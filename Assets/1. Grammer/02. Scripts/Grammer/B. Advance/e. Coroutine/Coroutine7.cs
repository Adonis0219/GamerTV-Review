using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine7 : MonoBehaviour
{
    // YieldInstruction 클래스
    // 코루틴은 일정 시간 대기하고 실행화는 방식으로 작동하고,
    // 해당 방식을 YieldInstruction 클래스가 정의

    float time;

    private void Start()
    {
        StartCoroutine(CoroutineTest());
    }

    IEnumerator CoroutineTest()
    {
        // 다음 Update 호출 시까지 대기 후 실행 -> 1프레임
        yield return null;

        // 다음 FixedUpdate 호출 시까지 대기 후 실행
        yield return new WaitForFixedUpdate();

        // float time 만큼의 시간이 지난 후 첫 프레임까지 대기 후 실행
        yield return new WaitForSeconds(time);

        // float time 만큼의 시간이 지난 후 첫 프레임까지 대기 후 실행
        // TimeScale의 영향을 받지 않음
        yield return new WaitForSecondsRealtime(time);

        // 모든 렌더링 작업이 완료되는 프레임이 끝날 때까지 대기 후 실행
        yield return new WaitForEndOfFrame();

        // 해당 조건이 참이 될 때까지 대기 후 실행
        yield return new WaitUntil(() => time > 10);
    }
}