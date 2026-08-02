// 어댑터 패턴
// - 호환되지 않는 두 개의 인터페이스를 서로 호환할 수 있도록 만들어 준다

// 객체 어댑터 구조
// : Composition(구성) 방식, 어댑터 내부에 Adaptee를 포함하는 방식

// InputSystem -> PlayerBase
//                    ㅣ
//               NpcToPlayer -> ImSangOk

//    Client    -> Target
//                    ㅣ
//                 Adapter   -> Adaptee

// Client  : Target 추상체(인터페이스)를 참조하여 동작을 호출
// Target  : Client가 사용하는 추상체 (인터페이스)
// Adapter : Target 상속 받아서 변환해주는 어댑터 역할
// Adaptee : 변환 대상

// ===================================================================

// 클래스 어댑터 구조 -> C#에서는 다중상속이 불가능하기에 사용하지 않는 구조
// : Inheritance(상속) 방식, 상속을 기반으로 동작하며, Adaptee의 기능을 재사용

// Client -> Target     Adaptee
//             ㅣ          ㅣ    (ㅣ : 상속)
//                Adapter