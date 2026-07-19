using UnityEngine;

namespace Factory
{
    public class SlimeFactory2 : BaseFactory2
    {
        [SerializeField] BaseMonster2 slime;

        public override BaseMonster2 CreateMonster()
        {
            return Instantiate(slime);
        }
    }
}
