using UnityEngine;

namespace SingletonTest6
{
    public class GameManager1 : Singleton<GameManager1>
    {
        int cnt = 0;

        public void GMTest()
        {
            Debug.Log("GameManager");
            cnt++;
            Debug.Log(cnt);
        }
    }

    public class SoundManager1 : Singleton<SoundManager1>
    {
        public void SMTest()
        {
            Debug.Log("SoundManager");
        }
    }

    public class Test2 : MonoBehaviour
    {
        [Singleton(typeof(GameManager1))] GameManager1 gameManager1;
        [Singleton(typeof(SoundManager1))] SoundManager1 soundManager1;

        private void Awake()
        {
            SingletonInjection.Injection(this);

            gameManager1.GMTest();
            soundManager1.SMTest();
        }
    }
}