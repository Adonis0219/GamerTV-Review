using UnityEngine;

namespace SingletonTest2
{
    // 유니티에서의 싱글톤 구현 방법
    // 즉시 초기화
    public class Singleton : MonoBehaviour
    {
        static Singleton instance;

        public static Singleton Instance { get { return instance; } }

        private void Awake()
        {
            if (Instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}

