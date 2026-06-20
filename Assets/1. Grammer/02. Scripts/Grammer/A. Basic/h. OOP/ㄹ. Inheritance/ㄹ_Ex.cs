using UnityEngine;

public class ㄹ_Ex : MonoBehaviour
{
    // 상속(Inheritance)은 기존 클래스(부모 클래스)를 기반으로 새로운 클래스(자식 클래스)를 만드는 객체 지향 프로그래밍의 개념입니다.

    // 다중 상속
    // 부모 클래스가 여러개

    public class Monster
    {
        public virtual void Attack() { }
    }

    public class Orc : Monster
    {
        public override void Attack() => Debug.Log("Orc Attack");
    }

    public class Ogre : Monster
    {
        public override void Attack() => Debug.Log("Ogre Attack");
    }

    // 죽음의 다이아몬드 구조
    // 하나의 부모 클래스를 두 개의 자식 클래스가 상속받고 다시 하나의 자식 클래스가 두 개의 부모 클래스를 상속받는 구조
    public class ChiefOrc : Orc//, Ogre
    {
        // C#에서는 다중 상속을 지원하지 않기 때문에, ChiefOrc 클래스는 Orc와 Ogre 클래스를 동시에 상속받을 수 없음
        // 따라서, ChiefOrc 클래스는 Orc 또는 Ogre 클래스 중 하나를 상속받아야 함

        // Attack() 메서드를 사용할 때 Orc와 Ogre 클래스 중 어떤 클래스의 Attack() 메서드를 사용할지 모르기 때문에, 다중 상속이 필요한 경우에는 인터페이스를 사용하여 구현하는 것이 일반적
    }
}
