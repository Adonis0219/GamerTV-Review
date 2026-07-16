using UnityEngine;

namespace SingletonTest
{
    // 게으른 싱글톤 초기화 (Lazy Initailization Singleton)
    // 인스턴스를 나중에 생성하는 방식
    public class Singleton
    {
        static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        private Singleton() { }

        public void Test() => Debug.Log("Test");
    }

    public class Test : MonoBehaviour
    {
        public void Awake()
        {
            Singleton.Instance.Test();
        }
    }
}