using UnityEngine;
using UnityEngine.UI;

namespace Factory
{
    public class FactoryTest4 : MonoBehaviour
    {
        [SerializeField] BaseFactory4 fireFac;
        [SerializeField] BaseFactory4 iceFac;

        [SerializeField] Button bt1;
        [SerializeField] Button bt2;

        public void Start()
        {
            bt1.onClick.AddListener(() =>
            {
                BaseMonster4 slime  = fireFac.CreateSlime();
                BaseMonster4 turtle = fireFac.CreateTurtle();
                slime.Attack();
                turtle.Attack();
            });

            bt2.onClick.AddListener(() =>
            {
                BaseMonster4 slime  = iceFac.CreateSlime();
                BaseMonster4 turtle = iceFac.CreateTurtle();
                slime.Attack();
                turtle.Attack();
            });
        }
    }
}
