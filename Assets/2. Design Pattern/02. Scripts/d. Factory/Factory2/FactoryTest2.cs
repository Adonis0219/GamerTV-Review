using UnityEngine;
using UnityEngine.UI;

namespace Factory
{
    public class FactoryTest2 : MonoBehaviour
    {
        [SerializeField] BaseFactory2 slimeFac;
        [SerializeField] BaseFactory2 turtleFac;

        [SerializeField] Button bt1;
        [SerializeField] Button bt2;

        public void Start()
        {
            bt1.onClick.AddListener(() =>
            {
                BaseMonster2 slime = slimeFac.CreateMonster();
                slime.Attack();
            });

            bt2.onClick.AddListener(() =>
            {
                BaseMonster2 turtle = turtleFac.CreateMonster();
                turtle.Attack();
            });
        }
    }
}
