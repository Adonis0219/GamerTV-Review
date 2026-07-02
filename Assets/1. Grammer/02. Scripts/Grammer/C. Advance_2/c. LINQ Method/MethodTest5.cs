
using System.Linq;
using UnityEngine;

public class MethodTest5 : MonoBehaviour
{
    public class Monster
    {
        public string MonsterName { get; set; }
        public int Hp { get; set; }
    }

    public class Item
    {
        public string MonsterName { get; set; }
        public string ItemName { get; set; }
    }

    void Start()
    {
        Monster[] monsters = new Monster[]
        {
            new Monster { MonsterName = "Goblin", Hp = 30 },
            new Monster { MonsterName = "Orc", Hp = 50 },
            new Monster { MonsterName = "Goblin", Hp = 20 },
            new Monster { MonsterName = "Troll", Hp = 80 },
            new Monster { MonsterName = "Orc", Hp = 10 }
        };

        Item[] items = new Item[]
        {
            new Item { MonsterName = "Goblin", ItemName = "Potion" },
            new Item { MonsterName = "Orc", ItemName = "1" },
            new Item { MonsterName = "Goblin", ItemName = "2" },
            new Item { MonsterName = "Troll", ItemName = "3" },
            new Item { MonsterName = "Orc", ItemName = "4" }
        };

        // Join : 두 컬렉션을 기준으로 조인(내부)을 수행
        var query = monsters.Join(items, monster => monster.MonsterName,
            items => items.MonsterName,
            (monster, items) => new { monster.MonsterName, items.ItemName });

        var query2 = from mob in monsters
                     join item in items on mob.MonsterName equals item.MonsterName
                     select new { mob.MonsterName, item.ItemName };

        // 외부 조인은 from문으로만 사용하자 메서드 형식은 너무 복잡쓰

        foreach (var item in query)
            Debug.Log($"MonsterName: {item.MonsterName}, ItemName: {item.ItemName}");
    }
}
