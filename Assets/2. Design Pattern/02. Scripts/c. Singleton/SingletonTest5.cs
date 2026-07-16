using UnityEngine;

namespace SingletonTest5
{
    // 제네릭 싱글톤
    // 싱글톤의 반복적인 코드를 제네릭으로 줄이는 방식
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        static T instance;

        public static T Instance
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

        static void SetupInstance()
        {
            instance = FindFirstObjectByType<T>();

            if (instance == null)
            {
                GameObject go = new GameObject();
                go.name = typeof(T).Name;
                instance = go.AddComponent<T>();
                DontDestroyOnLoad(go);
            }
        }
    }
}

