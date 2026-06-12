using UnityEngine;

public class EnumeratorTest : MonoBehaviour
{
    // Enumerator(열거자) : 배열이나 리스트와 같은 자료구조에 저장된 요소들을 순차적으로 접근할 수 있도록 해주는 인터페이스

    // 데이터 요소를 하나씩 리턴하는 기능
    // C#에서는 IEnumerable과 IEnumerator 인터페이스를 사용하여 열거자를 구현 
    void Start()
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

        foreach (var one in arr)
            Debug.Log(one); // 1, 2, 3, 4, 5
    }
}
