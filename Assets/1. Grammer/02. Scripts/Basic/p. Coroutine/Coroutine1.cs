using UnityEngine;
using UnityEngine.UI;

public class Coroutine1 : MonoBehaviour
{
    // 코루틴(Coroutine)은 Enumerator를 이용해 여러 프레임에 걸쳐 실행됨
    // 사전적 정의 - 업데이트 메서드와 달리 메서드 제어권을 유니티에 반환하고, 특정 조건이 되면 다시 진행하는 기능을 가진다
    Image image;
    private float alpha = 0f;
    private float fadeTime = 3.0f;

    void Start()
    {
        FadeIn();
    }

    void FadeIn()
    {
        // 한 프레임에 모든 결과값을 계산하여 띡(?) 보여줌
        // Update() 활용 -> Coroutine2.cs 참조
        while (alpha < 1.0f)
        {
            alpha += Time.deltaTime / fadeTime;
            image.color = new Color(1, 1, 1, alpha);
        }
    }
}