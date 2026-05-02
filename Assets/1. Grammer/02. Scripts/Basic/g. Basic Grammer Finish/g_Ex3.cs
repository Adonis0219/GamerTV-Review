using UnityEngine;

public class g_Ex3 : MonoBehaviour
{
    int num;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (num) // 조건식 (정수형, 문자형(C와 C++에서 불가능하기에 잘 사용 X), 열거형 등)
        {
            case 1: // 조건식의 결과가 1일 때 실행되는 코드
                Debug.Log("num은 1입니다.");
                break;
            case 2: // 조건식의 결과가 2일 때 실행되는 코드
                Debug.Log("num은 2입니다.");
                break;
            case 3:
                Debug.Log("num은 3입니다.");
                break;

            default:
                Debug.Log("num은 1, 2, 3이 아닙니다.");
                break;
        }
    }
}
