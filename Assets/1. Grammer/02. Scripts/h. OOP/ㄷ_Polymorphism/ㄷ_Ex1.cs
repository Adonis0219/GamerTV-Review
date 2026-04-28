using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ㄷ_Ex1 : MonoBehaviour
{
    public class Monster
    {
        public virtual void OnDamaged() { }
    }

    public class Orc : Monster
    {
        public override void OnDamaged() => Debug.Log("Orc Damaged");
    }

    public class Ogre : Monster
    {
        public override void OnDamaged() => Debug.Log("Ogre Damaged");
    }

    public class Player
    {
        public void Attack(Monster monster)
        {
            monster.OnDamaged(); // Monster 타입의 매개변수를 받아서 OnDamaged() 메서드를 호출
        }
    }

    private void Start()
    {
        Monster orc = new Orc();
        Monster ogre = new Ogre();

        List<Monster> monsters = new List<Monster>();

        monsters.Add(orc);
        monsters.Add(ogre);

        Player player = new Player();

        // Monster 타입의 리스트에 Orc와 Ogre 객체가 Monster 타입으로 저장되어 있지만,
        // 실제로는 Orc와 Ogre 객체가 저장되어 있기 때문에, Player 클래스의 Attack() 메서드를 호출할 때 각 객체의 OnDamaged() 메서드가 호출됩니다.
        foreach (Monster monster in monsters)
            player.Attack(monster); // Player 클래스의 Attack() 메서드를 호출하여 각 몬스터를 공격
    }
}
