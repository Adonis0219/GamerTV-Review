using UnityEngine;

namespace Deco1
{
    public class ItemB : MonoBehaviour
    {
        [SerializeField] Decorator _hpBuff;
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
                _hpBuff.Set(_warrior);
                _hpBuff.Operation();

                gameObject.SetActive(false);
            }
        }
    }
}
