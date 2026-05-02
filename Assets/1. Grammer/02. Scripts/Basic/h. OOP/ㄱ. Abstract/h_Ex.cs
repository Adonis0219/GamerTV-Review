using UnityEngine;

public class h_Ex : MonoBehaviour
{
    // 객체 지향

    // OOP : Object Oriented Programming
    // 모든 것을 객체로 표현하여 프로그래밍하는 방법
    // 객체 : 속성과 기능을 가진 독립된 존재 -> 사람, 자동차, 컴퓨터, 책 등을 모두 객체라고 표현 가능

    // 사람
    // 키, 몸무게, 나이 -> 속성(데이터, 필드)
    // 걷기, 밥먹기, 잠자기 -> 기능(메서드)


    // 1. 클래스
    // 객체를 만들기 위하 청사진(설계도) -> 사람이라는 클래스를 만들어서 사람 객체를 만들 수 있다
    // 자동차 설계도 = 클래스
    // 자동차 = 객체

    public class Person
    {
        // 속성(데이터, 필드)
        public string name;
        public int age;
       
        // 생성자 : 클래스명과 동일하고 반환 타입이 없음
        // 기본 생성자는 따로 만들지 않아도 기본적으로 가지고 있음
        // new 에약어와 함꼐 객체의 인스턴스를 만들어주는 함수
        public Person()
        {

        }

        // 기능(메서드)
        public void Walk() => Debug.Log("걷는다");
        
        public void Eat() => Debug.Log("밥을 먹는다");
    }

    public class Car
    {
        public string model;
        public int year;

        // 기본 생성자
        public Car()
        {

        }

        // 매개변수가 있는 생성자
        // 생성자 오버로딩 : 같은 이름의 생성자를 여러개 만들 수 있음
        public Car(string _model, int _year)
        {
            model = _model;
            year = _year;
        }

        // 종료자(소멸자) : 객체가 소멸될 때 자동으로 호출되는 메서드
        // -> C#에서는 가비지 컬렉터가 자동으로 메모리를 관리하기 때문에 일반적으로 종료자를 직접 구현할 필요는 없음
        // 특별한 경우가 아니고서야 굳이 사용 X 
        ~Car()
        {
            Debug.Log("Car 객체가 소멸되었습니다");
        }

        public void Drive() => Debug.Log("운전한다");
    }

    private void Start()
    {
        Person p; // 객체 생성
        p = new Person(); // 인스턴스 생성 후 할당
        p.name = "홍길동";
        p.age = 30;
        p.Walk();

        Car c;
        c = new Car("소나타", 2020);
        c.Drive();
    }
    // start()가 종료되면 stack 메모리의 p와 c는 사라지지만
    // heap 메모리에 생성된 Person과 Car 객체는 사라지지 않음
    // -> 언젠가 가비지 컬렉터가 heap 메모리를 정리할 때 Person과 Car 객체도 사라짐
}
