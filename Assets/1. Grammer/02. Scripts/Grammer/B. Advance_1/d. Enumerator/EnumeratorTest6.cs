using UnityEngine;
using System.Collections;
using System;

public class EnumeratorTest6 : MonoBehaviour
{
    public class MyList
    {
        public IEnumerator GetEnumerator()
        {
            int[] arr = {1,2,3,4,5};
            int index = -1;

            while (index < arr.Length - 1)
            {
                index++;
                // C# 컴파일러는 yield문이 사용된 메서드를 컴파일 단계에서 
                // IEnumerator/ IEnumerable 코드로 치환해서 내부적으로 구현
                yield return arr[index];

            }

            // 이중 반복이라 이해가 살짝 어려움
            index++;
            yield return arr[index];
            // 실행 중지 대기 후 다시 접근 시 
            // 여기서부터 실행
            index++;
            yield return arr[index];
            // 실행 중지 대기
            index++;
            yield return arr[index];
            // 실행 중지 대기
            index++;  
            yield return arr[index];
            // 실행 중지 대기
            index++;
            yield return arr[index];
            // 실행 중지 대기

            // 무한 대기 하므로 요소 열거를 끝내고 싶다면
            // yield break; 예약어 사용
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