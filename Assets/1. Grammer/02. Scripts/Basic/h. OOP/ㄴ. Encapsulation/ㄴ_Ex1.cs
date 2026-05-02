using UnityEngine;

public class ㄴ_Ex1 : MonoBehaviour
{
    int num = 10; // 캡슐화가 안된 상태

    public int Num // 프로퍼티로 캡슐화된 상태
    {
        get { return num; } // num의 값을 반환하는 접근자
        set { num = value; } // num의 값을 설정하는 설정자
    }   

    public float Num2 { get; set; } // 자동 구현 프로퍼티로 간단하게 캡슐화된 상태
}
