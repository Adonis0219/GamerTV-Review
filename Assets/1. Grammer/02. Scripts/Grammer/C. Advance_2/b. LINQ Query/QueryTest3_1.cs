using UnityEngine;
using System.Linq;

public class QueryTest3_1 : MonoBehaviour
{
    int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private void Start()
    {
        var result = from one in number
                     where one > 2
                     orderby one descending // descending : 내림차순, ascending : 오름차순
                     select one;

        foreach (var item in result)
            Debug.Log(item);
    }

    // orderby
    // 데이터의 정렬을 수행하는 연산자
    // 정렬할 대상이 IComparable 인터페이스를 구현하고 있어야 한다
}