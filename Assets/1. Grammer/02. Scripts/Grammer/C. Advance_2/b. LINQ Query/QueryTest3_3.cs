using UnityEngine;
using System.Linq;

public class QueryTest3_3 : MonoBehaviour
{
    int[] number = { 1, 2, 3, 4, 5 };

    private void Start()
    {
        var result = from one in number
                     group one by one > 2 into g // 3, 4, 5
                     select g; // 3, 4, 5

        // g의 원소는
        // { false, 1 }, { false, 2 }, { true, 3 }, { true, 4 }, { true, 5 }
        // 이렇게 되있으며 여기서 key와 value를 통해 그룹화된 결과를 확인 가능

        foreach (var item in result)
        {
            // result가 상속받은 IGroup<TKey, TElement> 인터페이스의 Key 속성을 통해 그룹화 기준을 확인 가능
            Debug.Log($"2보다 큰가? :: {item.Key}");

            // 각각 false, true에 해당하는 그룹화된 결과를 순회
            foreach (var one in item)
                Debug.Log(one);

            Debug.Log("====================================");
        }
    }

    // group A by B into C
    // group절은 데이터를 그룹화하는 쿼리식의 시작점
    // A : from절에서 뽑아낸 범위 변수(그룹화할 대상)
    // B : 그룹화 기준(그룹화할 조건)
    // C : 그룹화된 결과를 담을 범위 변수
}
