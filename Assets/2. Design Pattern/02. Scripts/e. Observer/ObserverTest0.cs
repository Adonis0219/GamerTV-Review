using UnityEngine;
using UnityEngine.UI;

namespace Observer
{
    public class ObserverTest0 : MonoBehaviour
    {
        [SerializeField] Obs obs1;
        [SerializeField] Obs obs2;
        [SerializeField] Button bt;

        void Start()
        {
            bt.onClick.AddListener(() =>
            {
                obs1.UpdateOps();
                obs2.UpdateOps();
            });
        }
    }
}
