using UnityEngine;
using UnityEngine.UI;

namespace Observer
{
    public class ObserverTest1 : MonoBehaviour
    {
        [SerializeField] Subject subject;
        [SerializeField] Button bt;

        void Start()
        {
            bt.onClick.AddListener(() =>
            {
                subject.action.Invoke();
            });
        }
    }
}
