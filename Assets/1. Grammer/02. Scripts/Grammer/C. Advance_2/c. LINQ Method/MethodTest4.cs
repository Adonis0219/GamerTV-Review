
using System.Linq;
using UnityEngine;

public class MethodTest4 : MonoBehaviour
{
    public class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }
    }

    // GroupBy : 특정 키를 기준으로 요소를 그룹화하여 반환

    void Start()
    {
        Monster[] monsters = new Monster[]
        {
            new Monster { Name = "Goblin", Hp = 30 },
            new Monster { Name = "Orc", Hp = 50 },
            new Monster { Name = "Goblin", Hp = 20 },
            new Monster { Name = "Troll", Hp = 80 },
            new Monster { Name = "Orc", Hp = 10 }
        };

        var grouped = monsters.GroupBy(m => m.Hp < 25);

        foreach (var item in grouped)
        {
            Debug.Log(item.Key); // true or false

            foreach (var one in item)
                Debug.Log(one.Name);
            
            Debug.Log("================================");
        }
    }
}
