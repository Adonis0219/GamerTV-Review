using UnityEngine;

namespace Observer2
{
    public class Observer2 : MonoBehaviour, IObs
    {
        [SerializeField] Subject subject;

        public void Start()
        {
            subject.AddObs(this);
        }

        public void UpdateObs()
        {
            Debug.Log($"Update Observer2!!!");
        }
    }
}