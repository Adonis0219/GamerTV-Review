using UnityEngine;

public class EnumeratorTest2 : MonoBehaviour
{
    public class MyList
    {
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }

        public class Enumerator
        {
            public object Current { get; }
            public bool MoveNext()
            {
                // 요소를 순차적으로 접근하는 로직 구현
                return true; // 예시에서는 항상 true 반환
            }
        }
    }

    void Start()
    {
        MyList myList = new MyList();

        // 돌릴 순 있지만 현재 코드에선 무한루프에 빠짐 -> EnumeratorTest3.cs에서 수정 예정
        foreach (var one in myList) // MyList 클래스가 IEnumerable 인터페이스를 구현했기 때문에 컴파일 에러 발생하지 않음
            Debug.Log(one); // 요소들을 순차적으로 접근하여 출력

        // foreach문 실행 조건
        // 1. 루프 대상이   GetEnumerator() 메서드가 존재해야 함
        // 2. GetEnumerator() 반환타입이 MoveNext() 메서드와 Current 속성(프로퍼티)을 구현해야 함
    }
}
