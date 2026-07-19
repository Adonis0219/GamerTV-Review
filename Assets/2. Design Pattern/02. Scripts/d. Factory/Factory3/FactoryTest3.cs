using UnityEngine;
using UnityEngine.UI;

namespace Factory
{
    public class FactoryTest3 : MonoBehaviour
    {
        [SerializeField] BaseFactory3 slimeFac;
        [SerializeField] BaseFactory3 turtleFac;

        [SerializeField] Button bt1;
        [SerializeField] Button bt2;

        public void Start()
        {
            bt1.onClick.AddListener(() =>
            {
                BaseMonster3 slime = slimeFac.CreateMonster();
                slime.Attack();
            });

            bt2.onClick.AddListener(() =>
            {
                BaseMonster3 turtle = turtleFac.CreateMonster();
                turtle.Attack();
            });
        }
    }
}
