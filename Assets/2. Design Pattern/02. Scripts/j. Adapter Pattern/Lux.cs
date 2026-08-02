using UnityEngine;

namespace Adapter
{
    public class Lux : PlayerBase
    {
        public override void Attack()
        {
            Debug.Log("Lux Attack");
        }

        public override void Idle()
        {
            Debug.Log("Lux Idle");
        }

        public override void Move()
        {
            Debug.Log("Lux Move");
        }

        public override void MoveTarget()
        {
            Debug.Log("Lux MoveTarget");
        }
    }
}
