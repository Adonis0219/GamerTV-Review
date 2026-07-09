using UnityEngine;

namespace DI
{
    public class SpecialAttack : MonoBehaviour, IAttackType
    {
        public void Attack()
        {
            Debug.Log("SpecialAttack");
        }
    }
}