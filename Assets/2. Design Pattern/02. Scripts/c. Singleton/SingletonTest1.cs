using UnityEngine;

namespace SingletonTest1
{
    // 일반적인 싱글톤 구현 방법

    // 즉시 초기화 싱글톤 (Eager Initialization Singleton)
    // 인스턴스를 미리 생성하는 싱글톤 방식
    public class Singleton
    {
        static Singleton instance = new Singleton();

        public static Singleton Instance { get { return instance; } }

        // 생성자를 private으로 선언해 외부에서는 인스턴스를 생성할 수 없게 한다. -> L25
        private Singleton() { }

        public void Test() => Debug.Log("Test");
    }

    public class Test : MonoBehaviour
    {
        public void Awake()
        {
            //Singleton singleton = new Singleton();

            Singleton.Instance.Test();
        }
    }
}

