using UnityEngine;

public class g_Ex2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = 4;
        string result;

        if (num % 2 == 0)
        {
            result = "짝수";
        }
        else
        {
            result = "홀수";
        }
        Debug.Log(result);  // 짝수

        num = 5;
        // 조건신 ? 표현식1 : 표현식2;    // 조건식이 참이면 표현식1, 거짓이면 표현식2를 반환하는 연산자
        result = (num % 2 == 0) ? "짝수" : "홀수";    // 삼항 연산자(조건 연산자) : if문의 전형적인 형태를 간략화
        Debug.Log(result);  // 홀수
    }
}
