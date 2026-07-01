using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class QueryTest3_5 : MonoBehaviour
{
    // join 연산자 : 두 개의 컬렉션을 조인하여 새로운 컬렉션을 생성 -> 두 데이터의 원본을 연결해줌

    public class MonsterName
    {
        public string Name { get; set; }
    }

    public class MonsterData
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Def { get; set; }
    }

    private void Start()
    {
        MonsterName[] names =
        {
            new MonsterName() { Name = "슬라임" },
            new MonsterName() { Name = "고블린" },
            new MonsterName() { Name = "드래곤" },
            new MonsterName() { Name = "오크" }
        };

        MonsterData[] datas =
        {
            new MonsterData() { Name = "슬라임", Hp = 50, Def = 5 },
            new MonsterData() { Name = "고블린", Hp = 100, Def = 10 },
            new MonsterData() { Name = "드래곤", Hp = 200, Def = 20 },
            new MonsterData() { Name = "", Hp = 150, Def = 15 }
        };

        // 광역 스킬 대미지
        int damage = 20;

        var monster = from one in names
                      join data in datas on one.Name equals data.Name
                      select new
                      {
                          Name = data.Name,
                          Hp = data.Hp - (damage - data.Def)
                      };

        // from a in A
        // join b in B on a.XXX equals b.YYY
        // a : from 절에서 뽑아낸 범위 변수
        // b : join 절에서 뽑아낸 범위 변수
        // on : 두 개의 컬렉션을 연결할 때 기준이 되는 속성
        // equals : 두 개의 컬렉션을 연결할 때 기준이 되는 속성의 값이 같은 경우에만 연결

        foreach (var one in monster)
            Debug.Log($"Name : {one.Name}\n남은 Hp : {one.Hp}");
        // 오크는 이름이 같지 않기 때문에 join 절에서 제외되어 출력되지 않음 -> 내부 조인
        // 이름이 없어도 합치고 싶다면? -> 외부 조인 / QueryTest3_6.cs 참조
    }
}
