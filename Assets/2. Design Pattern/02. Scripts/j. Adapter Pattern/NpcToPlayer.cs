using UnityEngine;

namespace Adapter
{
    // NpcBase와 PlayerBase를 연결해주는 어댑터 클래스
    public class NpcToPlayer : PlayerBase
    {
        [SerializeField] ImSangOk _iSO;
        public override void Idle()
        {
            Debug.Log("Npc Idle");
        }

        public override void Attack()
        {
            Debug.Log("Npc Sell 기능으로 Attack 대체");
            _iSO.Sell();
        }

        public override void Move()
        {
            Debug.Log("Npc Move");
        }

        public override void MoveTarget()
        {
            Debug.Log("Npc Buy 기능으로 MoveTarget 대체");
            _iSO.Buy();
        }
    }
}
