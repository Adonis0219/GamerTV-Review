using UnityEngine;

public class ㄹ_Ex2 : MonoBehaviour
{
    // 인터페이스 (interface)    
    // 간단하게 말하면 계약 혹은 약속이라고 정의
    // 공통된 기능을 정의하는 데 사용
    // 이벤트, 인덱서, 프로퍼티, 메소드 등을 포함
    // 추상클래스를 대체 가능
    // 객체 생성 불가능
    public interface IAttackable
    {
        public void Attack();
    }

    public class Orc : IAttackable
    {
        public void Attack()
        {
            Debug.Log("Orc Attack");
        }
    }

    public class Orge : IAttackable
    {
        // 인터페이스는 메서드의 구현이 없으므로, 반드시 구현해야 하는 메서드를 정의
        public void Attack() => Debug.Log("Ogre Attack");
    }
}
