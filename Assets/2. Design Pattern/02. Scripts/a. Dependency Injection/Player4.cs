using UnityEngine;

namespace DI
{
    public class Player4 : MonoBehaviour
    {
        IAttackType atkType;

        public void SetAttackType(IAttackType _atkType)
        {
            atkType = _atkType;
        }

        public void Attack()
        {
            atkType.Attack();
        }
    }
}
