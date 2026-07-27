using UnityEngine;

namespace Deco1
{
    // Decorator 클래스를 abstract로 구현했기 때문에 중간 부모의 역할이 돼
    // DecoComponent의 Operation()를 구현하지 않아도 된다
    public abstract class Decorator : DecoComponent
    {
        protected DecoComponent _decoComponent;

        // 인자를 필드에 대입, Decorator 반환
        public DecoComponent Set(DecoComponent decoComponent)
        {
            _decoComponent = decoComponent;
            return this;
        }
    }
}
