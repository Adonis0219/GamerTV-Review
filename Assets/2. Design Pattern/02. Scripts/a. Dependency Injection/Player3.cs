using UnityEngine;

namespace DI
{
    public class Player3 : MonoBehaviour
    {
        public enum AttackType
        {
            BaseAttack, SpecialAttack, MagicAttack
        }

        AttackType type;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            type = AttackType.SpecialAttack;
            Attack();
        }

        // Attack()가 Base, Special, Magic을(에게) 의존하고 있다
        public void Attack()
        {
            switch (type)
            {
                case AttackType.BaseAttack:     BaseAttack();       break;
                case AttackType.SpecialAttack:  SpecialAttack();    break;
                case AttackType.MagicAttack:    MagicAttack();      break;
            }
        }

        public void BaseAttack() => Debug.Log("BaseAttack");
        public void SpecialAttack() => Debug.Log("SpecialAttack");
        public void MagicAttack() => Debug.Log("MagicAttack");
    }
}
