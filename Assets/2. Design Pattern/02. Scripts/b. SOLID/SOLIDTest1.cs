using UnityEngine;

public class SOLIDTest1 : MonoBehaviour
{
    // SOLID
    
    // SRP(Single Responsibility Principle) : 단일 책임 원칙
    // - 클래스, 모듈, 함수는 하나의 책임만 가져야 하며, 변경 이유도 하나여야 한다

    // OCP(Open/Close Principle) : 개방 폐쇄 원칙
    // - 소프트웨어 요소는 확장에는 열려 있지만, 수정에는 닫혀 있어야 한다.
    // - 즉, 새로운 기능을 추가할 때 기존 코드를 변경하지 않고도 가능해야 한다.

    // LSP(Liskov Substitution Principle) : 리스코프 치환 원칙
    // - 자식 클래스는 부모 클래스의 역할을 대체할 수 있어야 한다.
    // - 이는 상속구조에서 일관성을 유지하는 데 중요
    //   - 필요없는 메서드 필드 상속 X
    //   - 중복 코드가 많다면 Interface 활용

    // ISP(Inteface Segregation Principle) : 인터페이스 분리 원칙
    // - 특정 클라이언트를 위한 인터페이스는 범용 인터페이스보다 더 유용해야 한다.
    // - 사용하지 않는 메서드에 의존하지 않도록 인터페이스를 작게 분리하는 것이 좋다.

    // DIP(Dependency Inversion Principle) : 의존성 역전 원칙
    // - 고수준의 모듈은 저수준의 모듈에 의존해서는 안되며, 두 모듈 모두 추상화에 의존해야 한다.
    // - 이를 통해 시스템의 유용성과 재사용성을 높일 수 있다.
}
    
