using UnityEngine;

namespace Adapter
{
    public class InputSystem : MonoBehaviour
    {
        [SerializeField] PlayerBase _pBase;

        public void Idle()
        {
            _pBase.Idle();
        }
        public void Attack()
        {
            _pBase.Attack();
        }
        public void Move()
        {
            _pBase.Move();
        }
        public void MoveTarget()
        {
            _pBase.MoveTarget();
        }
    }
}
