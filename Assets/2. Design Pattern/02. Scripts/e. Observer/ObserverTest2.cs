using UnityEngine;
using UnityEngine.UI;

namespace Observer2
{
    public class ObserverTest2 : MonoBehaviour
    {
        [SerializeField] Subject subject;
        [SerializeField] Button bt;

        void Start()
        {
            bt.onClick.AddListener(() =>
            {
                subject.NotifyObs();
            });
        }
    }
}
