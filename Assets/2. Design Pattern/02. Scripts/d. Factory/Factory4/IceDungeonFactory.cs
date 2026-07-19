using UnityEngine;

namespace Factory
{
    public class IceDungeonFactory : BaseFactory4
    {
        [SerializeField] BaseMonster4 iceSlime;
        [SerializeField] BaseMonster4 iceTurtle;

        public override BaseMonster4 CreateSlime()
        {
            return Instantiate(iceSlime);
        }

        public override BaseMonster4 CreateTurtle()
        {
            return Instantiate(iceTurtle);
        }
    }
}
