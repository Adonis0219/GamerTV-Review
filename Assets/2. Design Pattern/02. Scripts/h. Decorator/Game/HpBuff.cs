using UnityEngine;

namespace Deco1
{
    public class HpBuff : Decorator
    {
        [SerializeField] Warrior warrior;

        public override void Operation()
        {
            _decoComponent.Operation();
            warrior.hp += 10;
            Debug.Log("체력 10 버프");
        }
    }
}
