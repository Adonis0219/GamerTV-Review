using UnityEngine;

namespace Factory
{
    public abstract class BaseFactory2 : MonoBehaviour
    {
        public abstract BaseMonster2 CreateMonster();
    }
}
