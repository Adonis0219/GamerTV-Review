using UnityEngine;

namespace Adapter
{
    public class ImSangOk : NpcBase
    {
        public override void Buy()
        {
            Debug.Log("Buy");
        }

        public override void Sell()
        {
            Debug.Log("Sell");
        }
    }
}
