using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class i_Ex : MonoBehaviour
{
    // static
    // 사전적 의미로는 정적인, 움직이지 않음
    // 필드나 메소드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 함(메모리에 고정)

    // static 특징
    // 1. 클래스 자체에 소속되므로 단 한 개만 존재
    // 2. 메모리에 고정되어 있음
    // 3. 전역적으로 사용 가능

    public class Monster
    {
        public int score = 0;

        public void Dead() => score++;
    }

    public class StaticMonster
    {
        public static int score = 0;

        public void Dead() => score++;
    }

    void Start()
    {
        Test(); // 1 1 1
        StaticTest(); // 3
    }
    
    void Test()
    {
        Monster monster1 = new Monster();
        Monster monster2 = new Monster();
        Monster monster3 = new Monster();

        monster1.Dead();
        monster2.Dead();
        monster3.Dead();

        Debug.Log(monster1.score);
        Debug.Log(monster2.score);
        Debug.Log(monster3.score);
    }

    void StaticTest()
    {
        StaticMonster monster1 = new StaticMonster();
        StaticMonster monster2 = new StaticMonster();
        StaticMonster monster3 = new StaticMonster();

        monster1.Dead();
        monster2.Dead();
        monster3.Dead();

        Debug.Log(StaticMonster.score);
    }
}
