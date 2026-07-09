using UnityEngine;

namespace DI
{
    public class Player1 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Attack()가 BaseAttack()을(에게) 의존하고 있다
        public void Attack() => BaseAttack();

        public void BaseAttack() => Debug.Log("BaseAttack");
    }
}
