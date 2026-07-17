using UnityEngine;

public class FactoryTest0 : MonoBehaviour
{
    // 해당 코드는 SOLID의 개방폐쇄 원칙을 위반
    // 몬스터를 추가할 때마다 모든 코드를 수정해야 함(수정에 열려있음)
    // 프리팹 추가, start에 메서드 호출, Enum 추가, 메서드 로직 수정
    [SerializeField] GameObject slime;
    [SerializeField] GameObject turtle;

    enum Monster { Slime, Turtle }

    private void Start()
    {
        CreateMonster(Monster.Slime);
        CreateMonster(Monster.Turtle);
    }

    void CreateMonster(Monster monster)
    {
        switch (monster)
        {
            case Monster.Slime:
                Instantiate(slime);
                break;
            case Monster.Turtle:
                Instantiate(turtle);
                break;
            default:
                break;
        }
    }
}
