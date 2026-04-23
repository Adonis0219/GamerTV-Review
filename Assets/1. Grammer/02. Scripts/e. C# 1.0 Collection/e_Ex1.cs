using System.Collections;
using UnityEngine;

public class e_Ex1 : MonoBehaviour
{
    // ArrayList : 배열과 비슷하지만 크기를 동적으로 변경할 수 있는 컬렉션 자료구조 -> array의 단점 보완
    void Start()
    {
        ArrayList list = new ArrayList();
        // ArrayList는 다양한 타입의 데이터를 담을 수 있음 (object 타입으로 저장되기 때문)
        // Boxing이 발생하기 때문에 성능이 떨어질 수 있음 (값 타입의 데이터를 저장할 때)
        list.Add("Hello");
        list.Add(100);
        list.Add(3.14f);
        list.Add(true);
        list.Insert(1, "World"); // 인덱스 1에 "World" 삽입

        list.Remove(100); // 값으로 제거 : 100 제거(index : 2)
        list.RemoveAt(0); // 인덱스로 제거 : "Hello" 제거

        for (int i = 0; i < list.Count; i++)
            Debug.Log(list[i]); // World, 3.14, true
    }
}
