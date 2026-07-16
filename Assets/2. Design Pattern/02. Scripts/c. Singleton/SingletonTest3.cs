using UnityEngine;

namespace SingletonTest4
{
    // 일반적인 싱글톤은 멀티 스레드 환경에서 문제가 있다
    public class Singleton : MonoBehaviour
    {
        // 더블 체크 락킹 싱글톤 (잘 사용하진 않음) 
        static Singleton instance;
        static readonly object lockObj = new object();  // 락 오브젝트

        public static Singleton Instance
        {
            get
            {
                SetupInstance();

                return instance;
            }
        }
        
        private static void SetupInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null) // 두번째 체크
                    {

                        instance = FindFirstObjectByType<Singleton>();

                        if (instance != null)
                        {
                            GameObject go = new GameObject();
                            go.name = typeof(Singleton).Name;
                            instance = go.AddComponent<Singleton>();
                            DontDestroyOnLoad(instance);
                        }
                    }
                }
            }
        }
    }
}

