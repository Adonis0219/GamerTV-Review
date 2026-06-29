using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine5 : MonoBehaviour
{
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

            // 특정 조건 달성 시 yield break문으로 탈출 가능
            if (alpha > .5f) yield break;
        }
    }
}