using UnityEngine;

public class c_Ex4 : MonoBehaviour
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

    private void Start()
    {
        DownCasting(); // 부모 클래스에서 자식 클래스로의 형변환은 불가능하다
        UpCasting();   // 자식 클래스에서 부모 클래스로의 형변환은 가능하다
    }

    void DownCasting()
    {
        Monster mon = new Monster();

        Orc orc = (Orc)mon;   // Monster 타입의 mon을 Orc 타입으로 강제 형변환 (다운캐스팅) -> 부모 클래스에서 자식 클래스로의 형변환은 불가능하다

        orc.Grr();  // 에러
        // Monster 타입보다 Orc 타입이 더 구체적이므로, Monster 타입의 mon을 Orc 타입으로 강제 형변환하는 것은 불가능합니다.
        // C#에서는 자식 클래스가 더 큰 범위를 가지므로, 부모 클래스의 인스턴스를 자식 클래스의 인스턴스로 강제 형변환하는 것은 허용되지 않습니다.
        // Monster는 Orc 클래스의 Smash() 메서드에 대한 정보가 없다.
    }

    void UpCasting()
    {
        Orc orc = new Orc();
        Monster monster = (Monster)orc; // Orc 타입의 orc를 Monster 타입으로 강제 형변환 (업캐스팅) -> 자식 클래스에서 부모 클래스로의 형변환은 가능하다
        monster.Grr();  // Grr
        orc = (Orc)monster; // 재형변환은 가능하지만, monster가 실제로 Orc 타입의 인스턴스를 참조하고 있어야 합니다. 그렇지 않으면 InvalidCastException이 발생합니다.
        orc.Grr();
    }
}
