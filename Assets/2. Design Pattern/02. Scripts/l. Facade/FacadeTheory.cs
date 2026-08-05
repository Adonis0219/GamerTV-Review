// 퍼사드 패턴

// 퍼사드 패턴을 사용하지 않은 경우
//              SceneController
//          ㅣ         ㅣ         ㅣ
//        DataMgr   SoundMgr    UIMgr

// 퍼사드 패턴 적용
// SceneController  ->  GameManager           
//               ㅣ         ㅣ         ㅣ
//             DataMgr   SoundMgr    UIMgr

// Client  ->  Facade           
//       ㅣ      ㅣ      ㅣ
//      Sub1    Sub2    Sub3

// Client : 실제 퍼사드를 사용하는 외부 코드
// Facade : 서브 시스템의 복잡성을 감추고 클라이언트가 사용할 수 있는 단순한 인터페이스만 제공
// SubSystem : 각각의 기능을 수행하는 개별적인 클래스들


// 퍼사드 패턴의 장점
// 유지보수성 향상
// 확장성 향상

// 퍼사드 패턴의 단점
// 의존성의 증가
// 세부 제어 제한