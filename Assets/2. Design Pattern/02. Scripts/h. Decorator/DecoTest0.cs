using UnityEngine;

namespace Deco
{
    public class DecoTest0 : MonoBehaviour
    {
        void Start()
        {
            ConcreteComponentA conA = new ConcreteComponentA();
            conA.Operation();

            Debug.Log(":::::::::::::::::::::::::::::::::::::::::::::::::");

            ConcreteDecoratorB decB = new ConcreteDecoratorB(conA);
            decB.Operation();

            Debug.Log(":::::::::::::::::::::::::::::::::::::::::::::::::");

            ConcreteDecoratorC decC = new ConcreteDecoratorC(conA); 
            decC.Operation();

            Debug.Log(":::::::::::::::::::::::::::::::::::::::::::::::::");

            ConcreteDecoratorD decD = new ConcreteDecoratorD(conA);
            decD.Operation();


            Debug.Log(":::::::::::::::::::::::::::::::::::::::::::::::::");

            ConcreteDecoratorC decC2 = new ConcreteDecoratorC(new ConcreteDecoratorB(conA));
            decC2.Operation();
        }
    }
}
