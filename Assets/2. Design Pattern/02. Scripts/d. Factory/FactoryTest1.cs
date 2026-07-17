using UnityEngine;
using UnityEngine.UI;

namespace Factory
{
    public class FactoryTest1 : MonoBehaviour
    {
        [SerializeField] BaseFactory slimeFac;
        [SerializeField] BaseFactory turtleFac;

        [SerializeField] Button bt1;
        [SerializeField] Button bt2;

        public void Start()
        {
            bt1.onClick.AddListener(() =>
            {
                slimeFac.CreateMonster();
            });

            bt2.onClick.AddListener(() =>
            {
                turtleFac.CreateMonster();
            });
        }
    }
}
