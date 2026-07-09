using UnityEngine;

namespace DI
{
    public class MagicAttack : MonoBehaviour, IAttackType
    {
        public void Attack()
        {
            Debug.Log("MagicAttack");
        }
    }
}