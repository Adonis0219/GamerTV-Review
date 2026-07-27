using UnityEngine;

namespace Deco1
{
    public class Warrior : DecoComponent
    {
        public int hp, def, atk;

        void Awake()
        {
            hp = 10;
            def = 5;
            atk = 5;
        }

        public override void Operation()
        {
            Debug.Log($"{this.GetType().Name} State : Hp {hp}, Def {def}, Atk {atk}");
            Debug.Log("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        }
    }
}