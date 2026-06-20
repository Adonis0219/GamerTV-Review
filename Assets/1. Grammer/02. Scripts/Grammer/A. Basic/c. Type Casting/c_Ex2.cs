using UnityEngine;

public class c_Ex2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 200;
        Debug.Log($"a : {a}"); // a : 200

        uint b = (uint)a; // 명시적 형변환
        Debug.Log($"b : {b}"); // b : 200

        int c = -100;
        Debug.Log($"c : {c}"); // c : -100

        uint d = (uint)c; // 명시적 형변환
        Debug.Log($"d : {d}"); // d : 4294967196 -> 언더플로우가 발생한다. -> 부호 없는 정수형 자료형으로 변환할 때 음수 값을 양수로 변환하기 때문에 언더플로우가 발생한다.

        // 언더 플로우 : 데이터 형식의 최소값보다 작은 값을 저장하려고 할 때 발생하는 현상
    }
}
