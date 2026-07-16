using UnityEngine;

namespace SingletonTest5
{
    public class GameManager : Singleton<GameManager>
    {
        public void GMTest()
        {
            Debug.Log("GameManager");
        }
    }

    public class SoundManager : Singleton<SoundManager>
    {
        public void SMTest()
        {
            Debug.Log("SoundManager");
        }
    }

    public class Test : MonoBehaviour
    {
        public void Awake()
        {
            SoundManager.Instance.SMTest();
            GameManager.Instance.GMTest();  
        }
    }
}
