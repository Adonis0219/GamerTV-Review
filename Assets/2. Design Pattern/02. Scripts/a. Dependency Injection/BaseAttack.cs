using UnityEngine;

namespace DI
{
    public class BaseAttack : MonoBehaviour, IAttackType
    {
        public void Attack()
        {
            Debug.Log("BaseAttack");
        }
    }
}