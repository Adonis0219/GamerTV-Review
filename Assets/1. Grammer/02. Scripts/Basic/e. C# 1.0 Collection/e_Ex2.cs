using UnityEngine;
using System.Collections;

public class e_Ex2 : MonoBehaviour
{
    // HashTable : 키-값 쌍으로 데이터를 저장하는 컬렉션 자료구조 -> Dictionary의 단점 보완
    void Start()
    {
        Hashtable ht = new Hashtable();
        // Hashtable은 다양한 타입의 데이터를 담을 수 있음 (키와 값이 모두 object 타입으로 저장되기 때문)
        // Boxing이 발생하기 때문에 성능이 떨어질 수 있음 (값 타입의 데이터를 저장할 때)
        // ArrayList와 달리 키-값 쌍으로 데이터를 저장하기 때문에 검색이 빠름 (키를 통해 값에 접근)
        ht["Book"] = "책";
        ht["Pen"] = "펜";
        ht["Notebook"] = "노트북";
        ht[1.5f] = 15;

        Debug.Log(ht["Book"]);      // 책
        Debug.Log(ht["Pen"]);       // 펜
        Debug.Log(ht["Notebook"]);  // 노트북
        Debug.Log(ht[1.5f]);        // 15
    }
}
