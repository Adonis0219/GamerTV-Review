using UnityEngine;

public class c_Ex5 : MonoBehaviour
{
    class Monster   // 기반 클래스 (부모 클래스)
    {
        public void Grr()
        {
            Debug.Log("Grr...");
        }
    }

    class Orc : Monster // 파생 클래스 (자식 클래스 1)
    {
        public void Smash()
        {
            Debug.Log("Smash");
        }
    }
    class Troll : Monster { }   // 파생 클래스 (자식 클래스 2)

    // is, as 연산자(형변환 연산자)
    // is 연산자 : 객체가 특정 타입인지 확인하는 연산자 -> true / false 반환
    // as 연산자 : 객체를 특정 타입으로 안전하게 형변환하는 연산자 -> 형변환이 불가능하면 null 반환
    // is if as null 로 외우기

    private void Start()
    {
        Is();
        As();
    }

    void Is()
    {
        Monster monster = new Monster();
        Orc orc = new Orc();

        if (orc is Monster)
        {
            monster = (Monster)orc;
            monster.Grr();
        }
    }

    void As()
    {
        Monster monster = new Monster();
        Orc orc = new Orc();

        monster = orc as Monster;   // orc 객체를 Monster 타입으로 형변환 (as 연산자)
        monster = (Monster)orc;    // orc 객체를 Monster 타입으로 형변환 (명시적 형변환)
        // 두 개는 거의 비슷하지만 as 연산자는 형변환이 불가능할 때 null을 반환하는 반면, 명시적 형변환은 예외를 발생시킵니다.

        // monster = orc;  // 암시적 형변환

        if (monster != null)
        {
            monster.Grr();
        }

        // 주의 : as 연산자는 참조 타입에만 사용할 수 있습니다. 값 타입에는 사용할 수 없습니다.
    }
}
