using UnityEngine;

namespace Deco1
{
    public class ItemC : MonoBehaviour
    {
        [SerializeField] Decorator _hpBuff;
        [SerializeField] Decorator _atkBuff;
        [SerializeField] Decorator _defBuff;
        [SerializeField] Warrior _warrior;
       
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0, 0.5f, 0);
        }

        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger");

            if (other.CompareTag("Player"))
            {
                Debug.Log("ItemB");
                _atkBuff.Set(_defBuff.Set(_hpBuff.Set(_warrior)));
                _atkBuff.Operation();

                gameObject.SetActive(false);
            }
        }
    }
}
