// Command Pattern
// 명령(Command)을 객체(Object)로 캡슐화

// Stack에 Push한 ICommand를 하나씩 Pop 하면서 되돌리기(Undo)를 구현
// Queue에 Inqueue한 ICommand를 전부 Dequeue해서 리플레이를 구현

// Invoker -> Command
//               ㅣ 상속
// Receiver <- Concrete Command

// Invoker : Command 객체에 특정 작업을 수행해달라고 요청
// Command : 모든 커맨드가 상속받아야 되는 인터페이스 또는 추상 클래스
// ConcreteCommand : 특정 동작을 구현하며, 싱행 시 해당 동작을 Receiver에게 위임
// Receiver : 실제 작업을 수행하는 객체로, 어떤 일을 처리해야 되는지 알고 있는 대상