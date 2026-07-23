using UnityEngine;

namespace State
{
    public enum PlayerState
    {
        None, Idle, Move, Move_Target, Attack
    }

    public class Player : MonoBehaviour
    {
        public PlayerState playerState { get; set; }

        [SerializeField] Animator animator;
        [SerializeField] ParticleSystem particle1, particle2;

        private void Start()
        {
            playerState = PlayerState.Idle;
            OffAttackEffect();
        }

        private void Update()
        {
            UpdateAnimation();
            UpdateAction();
        }

        void UpdateAnimation()
        {
            switch (playerState)
            {
                case PlayerState.Idle: Idle(); break;
                case PlayerState.Move: Move(); break;
                case PlayerState.Move_Target: Move_Target(); break;
                case PlayerState.Attack: Attack(); break;
            }
        }
        void UpdateAction()
        {
            switch (playerState)
            {
                case PlayerState.Idle: Idle(); break;
                case PlayerState.Move: Move(); break;
                case PlayerState.Move_Target: Move_Target(); break;
                case PlayerState.Attack: Attack(); break;
            }
        }

        void Idle() { }
        void Move() { }
        void Move_Target() { }
        void Attack() { }

        void OffAttackEffect() { }
    } 
}
