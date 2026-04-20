using UnityEngine;

public class c_Ex1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float a = 69.1234f;
        Debug.Log($"a : {a}"); // a : 69.1234

        double b  = (double)a; // 명시적 형변환
        Debug.Log($"b : {b}"); // b : 69.1234

        float c = 0.1f;
        Debug.Log($"c : {c}"); // c : 0.1

        double d = (double)c;
        Debug.Log($"d : {d}"); // d : 0.10000000149011612 -> 오차가 발생한다. -> 부동소수점 오차

        // 실수형 자료형의 형변환은 변환 과정이 복잡하기에 오차가 발생할 수 있다. -> 부동소수점 오차
    }
}
