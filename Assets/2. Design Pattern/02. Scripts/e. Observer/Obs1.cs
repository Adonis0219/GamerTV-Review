using UnityEngine;

namespace Observer
{
    public class Obs1 : MonoBehaviour
    {
        [SerializeField] Subject subject;

        void Start()
        {
            subject.action += UpdateOps;    
        }

        public void UpdateOps()
        {
            Debug.Log($"Update {gameObject.name}");
        }
    }
}