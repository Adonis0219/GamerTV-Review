using UnityEngine;

public class EnumeratorTest3 : MonoBehaviour
{
    public class MyList
    {
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }

        public class Enumerator
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int index = -1; // 현재 요소의 인덱스

            // 현재 요소 반환
            public object Current { get {return num[index];} }

            // 다음 요소로 이동, 
            // 이동 성공 시 true, 더 이상 이동할 요소가 없다면 false
            public bool MoveNext()
            {
                if (index >= num.Length - 1)
                    return false; // 더 이상 요소가 없음을 나타냄
                
                // 요소를 순차적으로 접근하는 로직 구현
                index++;
                return index < num.Length;
            }
        }
    }

    void Start()
    {
        MyList myList = new MyList();

        // 근데 어떻게 foreach문이 Enumerator를 사용하는지 모름 -> EnumeratorTest4.cs에서 설명
        foreach (var one in myList) // MyList 클래스가 IEnumerable 인터페이스를 구현했기 때문에 컴파일 에러 발생하지 않음
            Debug.Log(one); // 요소들을 순차적으로 접근하여 출력
    }
}
