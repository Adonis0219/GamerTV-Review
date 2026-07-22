using UnityEngine;

namespace Observer2
{
    public class Observer1 : MonoBehaviour, IObs
    {
        [SerializeField] Subject subject;

        public void Start()
        {
            subject.AddObs(this);
        }

        public void UpdateObs()
        {
            Debug.Log($"Update {gameObject.name}");
        }
    }
}