namespace Deco
{
    // 데코레이터 추상 클래스 제작
    public abstract class Decorator : IComponent
    {
        public IComponent comp;

        public Decorator(IComponent _comp)
        {
            comp = _comp;
        }

        public abstract void Operation();
    }
}