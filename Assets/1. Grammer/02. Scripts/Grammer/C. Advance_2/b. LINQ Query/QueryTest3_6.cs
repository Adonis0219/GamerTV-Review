using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class QueryTest3_6 : MonoBehaviour
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
                      join data in datas on one.Name equals data.Name into result
                      from joinData in result.DefaultIfEmpty(new MonsterData() { Name = "없음" })
                      select new
                      {
                          Name = joinData.Name,
                          Hp = joinData.Hp - (damage - joinData.Def)
                      };

        // from a in A
        // join b in B on a.XXX equals b.YYY into ZZZ
        // from c in ZZZ.DefaultIfEmpty() // 외부 조인
        // into : 중간 결과 저장(ZZZ) -> ZZZ를 재가공하기 위해
        // c : ZZZ의 범위 변수
        // DefaultIfEmpty() : ZZZ가 비어있으면 기본값을 반환

        foreach (var one in monster)
            Debug.Log($"Name : {one.Name}\n남은 Hp : {one.Hp}");
    }
}
