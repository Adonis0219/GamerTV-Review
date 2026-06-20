using UnityEngine;
// IEnumerator 사용 위해
using System.Collections;

// 뭔가 Enumerator 클래스의 num 배열을 순회하기 위해 아래의 모든 것들을 구현해야 한다 -> 비효율적
// => yield return -> EnumeratorTest6.cs 참조
public class EnumeratorTest5 : MonoBehaviour
{
    // 실수 방지를 위해 인터페이스 추가 가능
    public class MyList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new Enumerator();
        }

        public class Enumerator : IEnumerator
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

            public void Reset()
            {
                index = -1;
            }
        }
    }

    void Start()
    {
        // foreach문이 내부적으로 돌아가는 방식
        MyList myList = new MyList();
        
        foreach (var one in myList)
            Debug.Log(one);
    }
}