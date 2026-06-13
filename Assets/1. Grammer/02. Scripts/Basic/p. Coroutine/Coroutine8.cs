using System.Collections;
using UnityEngine;

public class Coroutine8 : MonoBehaviour
{
    IEnumerator Test()
    {
        yield return new WaitForSeconds(1.0f);  // 1초 대기
        // 아래는 내부적 작동 방식

        // 1초 대기
        float time = 0;
        while (time < 1.0f)
        {
            yield return null;
            time += Time.deltaTime;
        }

        // Time.deltaTime을 누적하여 계산하기 때문에 오차가 발생할 수 있음
        // Ex) deltaTime = 0.11일 때
        // .99 -> 1.1 => 0.1초의 오차 발생
        // 극단적 예시이고 실제로는 0.000xx
    }
}
