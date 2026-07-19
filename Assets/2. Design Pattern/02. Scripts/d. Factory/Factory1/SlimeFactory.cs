using UnityEngine;

namespace Factory
{
    public class SlimeFactory : BaseFactory
    {
        [SerializeField] GameObject slime;

        public override void CreateMonster()
        {
            Instantiate(slime);
        }
    }
}
