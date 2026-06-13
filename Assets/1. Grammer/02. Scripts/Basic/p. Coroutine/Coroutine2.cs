using UnityEngine;
using UnityEngine.UI;

public class Coroutine2 : MonoBehaviour
{
    Image image;
    private float alpha = 0f;
    private float fadeTime = 3.0f;

    void Update()
    {
        // 매프레임마다 실행해야 할 코드를 계속 넣으면 Update()가 너무 길어짐
        // Coroutine 사용 -> Coroutine3.cs 참조
        while (alpha < 1.0f)
        {
            alpha += Time.deltaTime / fadeTime;
            image.color = new Color(1, 1, 1, alpha);
        }
    }
}