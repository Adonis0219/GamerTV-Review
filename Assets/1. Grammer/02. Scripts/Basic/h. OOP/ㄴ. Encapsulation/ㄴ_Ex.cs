using UnityEngine;

public class ㄴ_Ex : MonoBehaviour
{
    // 객체지향
    // 추상화, 캡슐화, 상속, 다형성 4가지 특징

    // 캡슐화란?
    // 관련이 있는 데이터와 메소드로 객체를 만들고 객체 밖에서 알아야 할 필요가 없는 내부 멤버를 숨기는 것
    // 정보은닉
    // 외부에서 멤버 변수를 직접 접근할 수 없게 만드는 것
    // 원칙
    // 1. 특별한 이유가 없으면 필드는 절대 public으로 선언하지 않는다.
    // 2. 접근이 필요한 경우 get, set 메서드를 사용하여 간접적으로 접근한다.
    // But, 코드가 너무 길어짐 -> 프로퍼티 사용

    // 접근 제한자 유형
    // 논리적 기준 : 클래스의 계층 구조에 따른 접근을 제한
    // public : 내부 및 파생 클래스, 외부
    // protected : 내부 및 파생 클래스
    // private : 내부

    // 물리적 기준 : 어셈블리 단위로 접근을 제한
    // internal : 내부
    // internal protected : 내부 및 파생 클래스



    void Start()
    {
        
    }
}

public class Test
{
    private int a; // private : 클래스 내부에서만 접근 가능
    
    // 설정자
    public void SetA(int value) // public 메서드로 a에 값을 설정할 수 있도록 함
    {
        a = value;
    }

    // 접근자
    public int GetA() // public 메서드로 a의 값을 가져올 수 있도록 함
    {
        return a;
    }
}