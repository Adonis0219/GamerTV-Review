using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ㄹ_Ex1 : MonoBehaviour
{
    // 추상 클래스 (abstract class)
    // 인스턴스를 생성할 수 없는 클래스
    // 추상 클래스는 다른 클래스가 상속받아야 하는 공통된 기능을 정의하는 데 사용
    // 추상 클래스는 추상 메서드를 포함할 수 있으며, 추상 메서드는 구현이 없는 메서드로, 자식 클래스에서 반드시 구현해야 합니다.

    public abstract class  Monster
    {
        public abstract void Attack();
    }

    public class Orc : Monster
    {
        // 추상 메서드를 구현하지 않으면 컴파일 오류가 발생

        public override void Attack()
        {
            Debug.Log("Orc Attack");
        }
    }

    public class Orge : Monster
    {
        public override void Attack() => Debug.Log("Ogre Attack");
    }

    public void Start()
    {
        // 추상클래스는 인스턴스를 생성할 수 없음
        // 완성되지 않은 클래스를 객체로 생성하여 내부의 메서드를 사용할 때 내용이 없으므로 불가능
        // Monster t = new Monster();

        Monster mon1 = new Orc();
        Monster mon2 = new Orge();

        List<Monster> mobs = new List<Monster>();
        mobs.Add(mon1);
        mobs.Add(mon2);

        foreach (var mob in mobs)
        {
            mob.Attack();
        }
    }
}
