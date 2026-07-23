using UnityEngine;

namespace State
{
    public class Player2 : MonoBehaviour
    {
        public bool isAttack;

        [SerializeField] Animator animator;
        [SerializeField] Enemy enemy;   

        State preState;
        State tempState;
        State curState;

        private void Start() { }

        public void SetState(State _state)
        {
            tempState = curState;
            curState = _state;
            preState = tempState;
        }
        
        public void Action()
        {
            if (preState != null)
                preState.OnStateExit();

            curState.OnStateEnter();
        }

        void EnemyDamage() => enemy.OnDamaged();
    } 
}
