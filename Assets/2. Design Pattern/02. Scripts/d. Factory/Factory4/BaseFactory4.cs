using UnityEngine;

namespace Factory
{
    public abstract class BaseFactory4 : MonoBehaviour
    {
        // 제품군(슬라임, 터틀)으로 구분
        public abstract BaseMonster4 CreateSlime();
        public abstract BaseMonster4 CreateTurtle();
    }
}
