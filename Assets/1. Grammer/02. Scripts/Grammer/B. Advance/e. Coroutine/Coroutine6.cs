using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine6 : MonoBehaviour
{
    Image image;
    private float alpha = 0f;
    private float fadeTime = 3.0f;

    void Start()
    {
        Coroutine co = StartCoroutine(FadeIn());

        StopCoroutine(co); // 가급적 이 방식 사용

        StopCoroutine(FadeIn());

        StopCoroutine("FadeIn");
    }

    IEnumerator FadeIn()
    {
        while (alpha < 1.0f)
        {
            alpha += Time.deltaTime / fadeTime;
            image.color = new Color(1, 1, 1, alpha);
            yield return null;
        }
    }
}