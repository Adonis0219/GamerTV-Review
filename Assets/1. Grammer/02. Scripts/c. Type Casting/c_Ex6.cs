using UnityEngine;

public class c_Ex6 : MonoBehaviour
{
    // 형변환
    // () 소괄호 안에 변환하려는 타입을 적어주면 된다. -> 명시적 형변환
    // 암시적 형변환 : 작은 타입에서 큰 타입으로 변환할 때는 자동으로 형변환이 일어난다.
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sbyte a = 127;
        Debug.Log(a);

        int b = (int)a; // 명시적 형변환
        Debug.Log(b);

        int c = 128;
        Debug.Log(c);

        sbyte d = (sbyte)c; // 명시적 형변환
        Debug.Log(d); // -128이 출력된다. -> 오버플로우
        // 오버플로우 : 변환하려는 타입의 범위를 초과하는 값을 변환할 때 발생하는 현상
        // = 데이터 형식의 최댓값보다 큰값을 넣을 경우 데이터를 다 담지 못하고 넘치는 현상
    }
}
