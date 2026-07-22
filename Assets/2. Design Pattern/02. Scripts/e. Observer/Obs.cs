using UnityEngine;

namespace Observer
{
    // 옵저버(Observer) : 상태 변화를 감지하고 이에 따라 반응하는 객체,
    // 쉽게 말해 특정 이벤트나 변화를 자동으로 통보 받아 반응하는 대상
    public class Obs : MonoBehaviour
    {
        public void UpdateOps()
        {
            Debug.Log($"Update {gameObject.name}");
        }
    }
}