using UnityEngine;

namespace Template
{
    public abstract class UIBase : MonoBehaviour
    {
        public abstract void Init();
        public abstract void Open();
        public abstract void Close();
        
        // 자식 클래스에서 메서드 내부의 내용 중복 발생 시 -> UIBase1.cs
    }
}
