using UnityEngine;
using static f_Ex2;

public class f_Ex2 : MonoBehaviour
{
    public class Return_Int
    {
        int num;

        public int Return() => num;
    }

    public class Return_Float
    {
        float num;
        public float Return() => num;
    }

    public class Return_Generic<T>
    {
        T num;
        public T Return() => num;
    }

    // T에 제약을 걸고 싶다면 where 키워드를 사용한다.
    // where T : struct => T는 값 형식이어야 한다.
    // where T : class => T는 참조 형식이어야 한다.
    // where T : new() => T는 매개변수가 없는 생성자가 있어야 한다.
    // where T : U => T는 U의 자식이어야 한다. 또 다른 형식 매개변수 U로부터 상속
    // where T : IComparable => T는 IComparable 인터페이스를 구현해야 한다.
    // where T : 부모 클래스 이름 => T는 특정 클래스의 자식이어야 한다.

    private void Start()
    {
        Return_Float f = new Return_Float();
        Return_Generic<int> intGeneric = new Return_Generic<int>();
        Return_Generic<float> floatGeneric = new Return_Generic<float>();

        int a = intGeneric.Return();
        float b = floatGeneric.Return();
    }
}
