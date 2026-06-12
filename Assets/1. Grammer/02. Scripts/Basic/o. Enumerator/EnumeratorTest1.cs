using UnityEngine;

public class EnumeratorTest1 : MonoBehaviour
{
    public class MyList
    {
        int[] num = new int[5] { 1, 2, 3, 4, 5 };
    }

    void Start()
    {
        MyList myList = new MyList();

        // foreach (var one in myList) // MyList 클래스는 IEnumerable 인터페이스를 구현하지 않았기 때문에 컴파일 에러 발생
        //     Debug.Log(one);
        // 해결 방법 : MyList 클래스가 IEnumerable 인터페이스를 구현하도록 수정해야 함
        // GetEnumerator() 메서드를 구현하여 열거자를 반환하도록 해야 함
        // MoveNext() 메서드와 Current 속성을 구현하여 열거자가 요소를 순차적으로 접근할 수 있도록 해야 함 -> EnumeratorTest2.cs에서 구현 예정
    }
}
