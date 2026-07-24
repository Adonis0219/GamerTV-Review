using UnityEngine;

namespace Deco
{
    // B 역할 클래스, 데코레이터 상속
    public class ConcreteDecoratorB : Decorator
    {
        // : base() - 부모 클래스의 생성자를 호출하는 문법
        public ConcreteDecoratorB(IComponent _comp) : base(_comp)
        {

        }

        public override void Operation()
        {
            comp.Operation();
            Debug.Log("추가 기능 B");
        }
    }
}
