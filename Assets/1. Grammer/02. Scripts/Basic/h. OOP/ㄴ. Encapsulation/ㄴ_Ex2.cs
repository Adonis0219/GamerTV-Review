using UnityEngine;

public class ㄴ_Ex2 : MonoBehaviour
{
    private int num;    // 인스펙터 창에서 보이지 않음
    protected int num1; // 인스펙터 창에서 보이지 않음, 자식 클래스에서 접근 가능
    public int num2;    // 인스펙터 창에서 보임

    [SerializeField]
    private int num3; // 인스펙터 창에서 보이지만 외부에서는 접근 불가

    [HideInInspector]
    public int num4;    // 인스펙터 창에서 보이지 않지만 외부에서는 접근 가능

    // [] : 어트리뷰트(Attribute)라고 불리는 메타데이터를 사용하여 변수의 접근성을 제어할 수 있음
    // 컴퓨터가 읽을 수 있는 주석으로 이해 (쉽게)

    public Test5 test = new Test5(); // 인스펙터 창에서 설정 가능 

    // 해당 경우에만 가능
    [field:SerializeField] // 자동 구현 프로퍼티도 인스펙터 창에서 보이도록 하는 어트리뷰트
    public int Num { get; set; }
}

// 직렬화 (Serialization) : 객체의 상태를 저장하거나 전송하기 위해 객체를 일련의 바이트로 변환하는 과정
[System.Serializable] // 클래스가 인스펙터 창에서 보이도록 하는 어트리뷰트
public class Test5
{
    public int num;     // 인스펙터 창에서 보임
    public int num2;    // 인스펙터 창에서 보임
    private int num3;   // 인스펙터 창에서 보이지 않음
}