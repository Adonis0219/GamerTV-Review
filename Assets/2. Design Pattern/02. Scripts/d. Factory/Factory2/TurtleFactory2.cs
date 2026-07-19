using UnityEngine;

namespace Factory
{
    public class TurtleFactory2 : BaseFactory2
    {
        [SerializeField] BaseMonster2 turtle;

        public override BaseMonster2 CreateMonster()
        {
            return Instantiate(turtle);
        }
    }
}
