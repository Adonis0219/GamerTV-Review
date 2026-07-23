using UnityEngine;

namespace State
{
    public class PlayerIdle : State
    {
        [SerializeField] Player2 player;

        public override void OnStateEnter()
        {
            throw new System.NotImplementedException();
        }

        public override void OnStateExit() { }

        public override void OnStateUpdate() { }
    }
}
