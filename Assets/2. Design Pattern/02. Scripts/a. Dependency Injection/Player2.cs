using UnityEngine;

namespace DI
{
    public class Player2 : MonoBehaviour
    {
        public enum AttackType
        {
            BaseAttack, SpecialAttack,
        }

        AttackType type;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            type = AttackType.SpecialAttack;
            Attack();
        }

        // Attack()가 BaseAttack()을(에게) 의존하고 있다
        public void Attack()
        {
            if (type == AttackType.BaseAttack) BaseAttack();
            else if (type == AttackType.SpecialAttack) SpecialAttack();
        }

        public void BaseAttack() => Debug.Log("BaseAttack");
        public void SpecialAttack() => Debug.Log("SpecialAttack");
    }
}
