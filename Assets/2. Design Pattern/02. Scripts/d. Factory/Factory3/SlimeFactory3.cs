using UnityEngine;

namespace Factory
{
    public class SlimeFactory3 : BaseFactory3
    {
        public override BaseMonster3 CreateMonster()
        {
            return Instantiate(baseMonster);
        }
    }
}
