using UnityEngine;

public class d_Ex : MonoBehaviour
{
    // C# 1.0에서 나온 문법
    // C# 2.0에서 제네릭이 나오기 때문에 object 자료형을 따로 배움
    // object 자료형 : 모든 데이터를 다룰 수 있는 최상위 자료형 (모든 자료형 클래스의 부모 클래스)
    // object 자료형은 참조 타입
    private void Start()
    {
        object a = 123;
        object b = 123.45f;
        object c = true;
        object d = "반가워요";

        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(c);
        Debug.Log(d);
    }
}
