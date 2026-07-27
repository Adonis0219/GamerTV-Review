using UnityEngine;

namespace Deco1
{
    public class AtkBuff : Decorator
    {
        [SerializeField] Warrior warrior;

        public override void Operation()
        {
            _decoComponent.Operation();
            warrior.atk += 10;
            Debug.Log("공격력 10 버프");
        }
    }
}
