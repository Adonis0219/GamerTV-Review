using UnityEngine;
using System.Linq;

public class QueryTest3_2 : MonoBehaviour
{
    int[] number = { 1, 2, 3, 4, 5 };

    private void Start()
    {
        var result = from one in number
                     where one > 2  // 3, 4, 5
                     orderby one ascending // 3, 4, 5
                     // 익명 타입(Anonymous Type)으로 결과를 재가공
                     select new { Result = one * one }; // 9, 16, 25 

        foreach (var item in result)
            Debug.Log(item);
    }

    // select
    // select절은 최종 결과를 추출하는 쿼리식의 마침표같은 존재
    // 익명 타입으로 결과를 재가공 가능
}