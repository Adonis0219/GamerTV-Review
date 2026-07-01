using UnityEngine;
using System.Linq;

public class QueryTest2 : MonoBehaviour
{
    int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private void Start()
    {
        var result = from one in number
                     select one;

        foreach (var item in result)
            Debug.Log(item);
    }

    // from
    // 모든 LINQ 쿼리식(Query Expression)은 반드시 from 절로 시작해야 한다.
    // from '범위변수' in '데이터 원본'

    // 조건 걸기 -> QueryTest3.cs 참조
}
