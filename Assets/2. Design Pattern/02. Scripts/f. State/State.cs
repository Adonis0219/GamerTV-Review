using UnityEngine;

namespace State
{
    public abstract class State : MonoBehaviour
    {
        // 상태 시작 시 한 번 호출
        public abstract void OnStateEnter();
        // 상태 중 매 프레임 호출
        public abstract void OnStateUpdate();
        // 상태 종료 시 한 번 호출
        public abstract void OnStateExit();
    }
} 