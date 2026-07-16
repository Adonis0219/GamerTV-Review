using UnityEngine;

namespace SingletonTest3
{
    // 유니티에서의 싱글톤 구현 방법
    // 게으른 초기화
    public class Singleton : MonoBehaviour
    {
        static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    SetupInstance();
                }

                return instance;
            }
        }
        
        private static void SetupInstance()
        {
            instance = FindFirstObjectByType<Singleton>();

            if (instance != null)
            {
                // 빈 게임오브젝트 생성
                GameObject go = new GameObject();
                // 이름 변경
                go.name = typeof(Singleton).Name;
                // 싱글톤 컴포넌트 추가
                instance = go.AddComponent<Singleton>();
                // 돈디스
                DontDestroyOnLoad(instance);
            }
        }
    }
}

