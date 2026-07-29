using UnityEngine;

namespace Template
{
    public abstract class PlayerBase : MonoBehaviour
    {
        // 필요한 경우 재정의하여 사용
        public virtual void Idle()
        {
            // 공용 Idle 구현
        }

        public virtual void Move()
        {
            // 공용 Move 구현
        }

        // 자식 클래스에서 필수적으로 구현
        public abstract void MoveTarget();
        public abstract void Attack();
    }
}
