using UnityEngine;

namespace Factory
{
    public class FireDungeonFactory : BaseFactory4
    {
        [SerializeField] BaseMonster4 fireSlime;
        [SerializeField] BaseMonster4 fireTurtle;

        public override BaseMonster4 CreateSlime()
        {
            return Instantiate(fireSlime);
        }

        public override BaseMonster4 CreateTurtle()
        {
            return Instantiate(fireTurtle);
        }
    }
}
