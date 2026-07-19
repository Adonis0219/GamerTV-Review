using UnityEngine;

namespace Factory
{
    public abstract class BaseFactory3 : MonoBehaviour
    {
        // 추상체 참조
        public BaseMonster3 baseMonster;

        public abstract BaseMonster3 CreateMonster();
    }
}
