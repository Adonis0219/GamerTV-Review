using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class e_Ex : MonoBehaviour
{
    // 컬렉션(Collection) : 같은 성격을 가진 데이터 모음을 담는 자료구조
    // 배열, 리스트, 큐, 스택, 해시 테이블 등이 있음

    // C# 1.0에서 나온 컬렉션 자료구조 (System.Collections 네임스페이스)
    // ArrayList
    // HashTable
    // Queue
    // Stack

    private void Start()
    {
        int[] arr = new int[40];
        arr[0] = 100;

        arr = new int[50]; // 배열은 크기를 변경할 수 없음 (새로운 배열이 만들어짐)
        Debug.Log(arr[0]); // 0 (새로운 배열이 만들어졌기 때문에 기존 데이터는 사라짐)
    }
}
