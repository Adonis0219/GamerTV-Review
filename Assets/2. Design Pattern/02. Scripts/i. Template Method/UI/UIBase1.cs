using UnityEngine;
using UnityEngine.UI;

namespace Template
{
    public abstract class UIBase1 : MonoBehaviour
    {
        [SerializeField] Image _bg;

        // 필수 구현
        public abstract void Init();
        // 중복 미리 구현
        // 내용이 같다 -> 구현하지 않음
        // 내용이 다르다 -> override
        public virtual void Open()
        {
            float targetScale = 1.0f;
            
            // 내용~~
        }
        public abstract void Close();
    }
}
