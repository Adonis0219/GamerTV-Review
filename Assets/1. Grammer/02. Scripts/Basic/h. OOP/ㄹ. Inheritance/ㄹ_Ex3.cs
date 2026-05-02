using UnityEngine;

public class ㄹ_Ex3 : MonoBehaviour
{
    // 인터페이스는 클래스가 아니기 때문에 다중 상속이 가능
    public interface IAttackable
    {
         public void Attack();
    }

    public interface IMoveable
    {
        public void Move();
    }

    public class Orc : IAttackable, IMoveable
    {
        public void Attack()
        {
            Debug.Log("Orc Attack");
        }
        public void Move()
        {
            Debug.Log("Orc Move");
        }
    }
}

