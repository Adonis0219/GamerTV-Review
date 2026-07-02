using System.Linq;
using UnityEngine;

public class MethodTest8 : MonoBehaviour
{
    public class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }
    }

    void Start()
    {
        Monster[] monsters = new Monster[]
        {
            new Monster { Name = "Monster1", Hp = 100 },
            new Monster { Name = "Monster2", Hp = 200 },
            new Monster { Name = "Monster3", Hp = 300 },
            new Monster { Name = "Monster4", Hp = 400 },
            new Monster { Name = "Monster5", Hp = 500 }
        };

        // 메소드 체이닝을 사용하여 쿼리 작성
        var result = monsters.Where(m => m.Hp>200)
                             .OrderByDescending(m => m.Hp)
                             .Select(monster => new { monster.Name, monster.Hp });

        foreach (var one in result)
            Debug.Log($"Name: {one.Name}, Hp: {one.Hp}");
    }
}
