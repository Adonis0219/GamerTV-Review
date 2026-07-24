using UnityEngine;

namespace Deco
{
    // A 역할 클래스, 인터페이스 상속
    public class ConcreteComponentA : IComponent
    {
        public void Operation()
        {
            Debug.Log("기본 동작 A");
        }
    }
}
