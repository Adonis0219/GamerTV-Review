using UnityEngine;
using System.Linq;

public class QueryTest3 : MonoBehaviour
{
    int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private void Start()
    {
        var result = from one in number
                     where one > 2
                     select one;

        foreach (var item in result)
            Debug.Log(item);
    }

    // where
    // 필터 역할을 하는 연산자. from 절에서 뽑아낸 '범위 변수'가 가져야 하는 조건을 설정
    // 그리고 해당 조건에 부합하는 데이터만 골라낸다
}