using UnityEngine;

namespace Factory
{
    public class TurtleFactory : BaseFactory
    {
        [SerializeField] GameObject turtle;

        public override void CreateMonster()
        {
            Instantiate(turtle);
        }
    }
}
