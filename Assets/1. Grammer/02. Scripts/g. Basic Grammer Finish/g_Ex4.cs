using UnityEngine;

public class g_Ex4 : MonoBehaviour
{
    // foreach문은 배열이나 리스트와 같은 컬렉션의 모든 요소를 반복적으로 처리할 때 사용되는 반복문입니다.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        // foreach (자료형 변수명 in 컬렉션) { 반복할 코드 }
        foreach (var item in arr) // arr의 각 요소를 item에 순차적으로 할당하여 반복
        {
            Debug.Log(item); // item을 출력
        }
    }
}
