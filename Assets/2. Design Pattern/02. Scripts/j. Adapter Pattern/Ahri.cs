using UnityEngine;

namespace Adapter
{
    public class Ahri : PlayerBase
    {
        public override void Attack()
        {
            Debug.Log("Ahri Attack");
        }

        public override void Idle()
        {
            Debug.Log("Ahri Idle");
        }

        public override void Move()
        {
            Debug.Log("Ahri Move");
        }

        public override void MoveTarget()
        {
            Debug.Log("Ahri MoveTarget");
        }
    }
}
