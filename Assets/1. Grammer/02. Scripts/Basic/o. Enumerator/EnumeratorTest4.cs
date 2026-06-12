using UnityEngine;

public class EnumeratorTest4 : MonoBehaviour
{
    // 구현 실수를 방지하기 위해 Interface 사용 -> EnumeratorTest5.cs 참조
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
        // foreach문이 내부적으로 돌아가는 방식
        MyList myList = new MyList();
        MyList.Enumerator e = myList.GetEnumerator();

        // 다음 번 호출까지 대기 후 다시 실행하는 지연호출이 가능하다
        e.MoveNext();
        Debug.Log(e.Current);
        e.MoveNext();
        Debug.Log(e.Current);
        e.MoveNext();
        Debug.Log(e.Current);
        e.MoveNext();
        Debug.Log(e.Current);
        e.MoveNext();
        Debug.Log(e.Current);        

        // while문으로도 가능
        while (e.MoveNext())
            Debug.Log(e.Current);
    }
}
