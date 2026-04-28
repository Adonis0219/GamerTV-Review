using UnityEngine;

public class ㄷ_Ex : MonoBehaviour
{
    // 다형성 (Polymorphism) : 하나의 객체가 여러 형태를 가질 수 있는 능력
    // 상속을 받아서 만들어진 파생 클래스를 통해 다형성을 보여줄 수 있다

    public class Monster
    {
        public void Attack() => Debug.Log("Attack");

        // 가상 메서드 (Virtual Method) : 파생 클래스에서 재정의할 수 있는 메서드
        // 파생 클래스에서 재정의가 필수는 아님.
        public virtual void V_Attack() => Debug.Log("Virtual Attack"); // virtual 키워드를 사용하여 가상 메서드로 선언
    }

    public class Orc : Monster
    {
        // 오버라이딩 (Overriding) : 파생 클래스에서 가상 메서드를 재정의하여 새로운 기능을 제공하는 것
        public override void V_Attack() => Debug.Log("Orc Attack"); // override 키워드를 사용하여 가상 메서드를 재정의
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Orc orc = new Orc();
        orc.Attack(); // Orc 클래스는 Monster 클래스를 상속받았기 때문에 Attack() 메서드를 사용할 수 있다
        orc.V_Attack(); // Orc 클래스에서 V_Attack() 메서드를 재정의했기 때문에 Orc Attack 출력
    }
}
