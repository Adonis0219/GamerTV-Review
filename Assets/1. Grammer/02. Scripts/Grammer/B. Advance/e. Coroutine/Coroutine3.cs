using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine3 : MonoBehaviour
{
    // 코루틴 사용 조건
    // 1. MonoBehaviour를 상속받아야 함
    // 2. IEnumerator를 반환하는 함수
    // 3. yield return (조건)을 사용한다 -> Coroutine4.cs 참조
    //    yield return을 만나는 순간, 다음 줄부터 실행되는 프레임이 다름
    // 4. yield break를 만나면 코루틴이 종료됨 -> Coroutine5.cs 참조
    // 5. 코루틴을 실행하는 게임오브젝트가 비활성화되거나 파괴되면 코루틴 종료

    // 코루틴 사용 방법
    // 1. StartCoroutine : 코루틴 실행 메서드
    //    StartCoroutine(string methodName) -> 특별한 경우가 아니라면 사용 X (매직스트링)
    // 2. StopCoroutine : 코루틴 종료 메서드 -> Coroutine6.cs 참조
    // 3. StopAllCoroutine : 해당 스크립트에 있는 모든 코루틴 종료

    // 코루틴 작동 방식
    // C# Enumerator를 활용해서 만들어짐
    // 차이점은 열거할 때마다 특정 프레임에서 실행되도록 작동함

    Image image;
    private float alpha = 0f;
    private float fadeTime = 3.0f;

    void Start()
    {
        StartCoroutine(FadeIn());   // 가급적 이 방식으로 사용
    }

    IEnumerator FadeIn()
    {
        while (alpha < 1.0f)
        {
            alpha += Time.deltaTime / fadeTime;
            image.color = new Color(1, 1, 1, alpha);
            // 다음 프레임까지 대기
            yield return null;
        }
    }
}