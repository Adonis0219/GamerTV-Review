using UnityEngine;

public class g_Ex5 : MonoBehaviour
{
    // 키워드
    // break : 반복문 탈출
    // continue : 반복문에서 다음 반복으로 넘어감
    // goto : 특정 위치로 이동 (권장하지 않음)
    /// goto문은 해당 레이블 문으로 이동 -> 레이블 문은 식별자에 : 붙여서 표현

    void Continue()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue; // 짝수일 때 다음 반복으로 넘어감
            }
            Debug.Log(i); // 1, 3, 5, 7, 9 출력
        }
    }

    void Goto()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (i == 1 && k == 2)
                        goto EXIT_FOR; // goto문을 사용하지 않으면 break문을 여러번 써야 한다
                }
            }
        }
    EXIT_FOR:
        Debug.Log("Exited the loop");
    }
}
