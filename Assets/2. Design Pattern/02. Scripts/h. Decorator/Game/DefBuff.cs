using UnityEngine;

namespace Deco1
{
    public class DefBuff : Decorator
    {
        [SerializeField] Warrior warrior;

        public override void Operation()
        {
            _decoComponent.Operation();
            warrior.def += 10;
            Debug.Log("방어력 10 버프");
        }
    }
}
