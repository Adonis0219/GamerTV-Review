using UnityEngine;

public class LINQTest0 : MonoBehaviour
{
    // LINQ(Language INtegrated Query)는 C# 언어에 통합된 질의(Query) 기능을 말함

    // var : C# 3.0부터 추론 기능이 추가되면서 메서드의 지역변수 선언을 타입에 관계없이 var 예약어로 사용 가능
    // 메서드의 반환타입을 var로 받아주면 추가 확인 작업이 필요 -> 별로
    void Start()
    {
        int i = 5;
        var j = 10;

        Debug.Log(i.GetType().FullName);
        Debug.Log(j.GetType().FullName);
    }
}
