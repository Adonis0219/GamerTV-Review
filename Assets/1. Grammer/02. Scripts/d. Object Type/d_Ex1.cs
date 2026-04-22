using UnityEngine;

public class d_Ex1 : MonoBehaviour
{
    // Boxing : 값 타입을 참조 타입으로 변환하는 과정 (값 타입 -> 참조 타입)
    // 값 타입은 스택에 저장되고 참조 타입은 힙에 저장되는데, 값 타입을 참조 타입으로 변환할 때는 값이 힙으로 복사되어 저장됩니다. 이 과정을 Boxing이라고 합니다.
    // Unboxing : 참조 타입을 값 타입으로 변환하는 과정 (참조 타입 -> 값 타입)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object a = 5; // Boxing : int 값이 object 참조 타입으로 변환되어 저장됨
        int b = (int)a; // Unboxing : object 참조 타입이 int 값으로 변환되어 저장됨
    }
}
