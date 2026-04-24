using UnityEngine;

public class f_Ex : MonoBehaviour
{
    //  Generic(일반화) : 클래스, 메서드, 인터페이스, 델리게이트 등에 사용할 수 있는 형식 매개변수

    // 고래, 고양이, 사람 >> 동물
    // 일반화 : 특수한 개념에서 공통된 개념을 추출하여 일반적인 개념으로 만드는 것

    void Start()
    {
        
    }

    public void Copy(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }

    // 메소드(함수) 오버로딩 : 같은 이름의 메서드를 여러 개 정의하는 것 -> 매개변수의 타입과 개수로 구분
    public void Copy(float[] source, float[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }

    // 다른 타입을 복사하고 싶으면 또 다른 메서드를 만들어야 함 >> 코드 중복 발생
    // object로 하면 모든 타입을 받을 수 있지만, 매번 박싱과 언박싱이 발생하여 성능이 저하된다
    public void Copy(object[] source, object[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }

    // 제네릭으로 해결
    // T : Type의 약자, 형식 매개변수 -> 제네릭의 자료형을 나타내는 매개변수
    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }
}