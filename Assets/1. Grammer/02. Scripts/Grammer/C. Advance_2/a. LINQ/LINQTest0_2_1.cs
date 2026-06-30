using UnityEngine;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

public class LINQTest0_2_1 : MonoBehaviour
{
    // LINQ 사용 -> LINQTest0_2_1.cs
    class Person
    {
        string _name;
        int _age;

        public string Name { get; set; }

        public int Age { get; set; }

        // 자동구현 프로퍼티
        public int Height { get; set; }

        public void Result()
        {
            Debug.Log($"Name : {Name}, Age : {Age}, Height : {Height}");
        }
    }

    void Start()
    {
        List<Person> people = new List<Person>()
        {
            new Person {Name = "A", Age = 10, Height = 150},
            new Person {Name = "B", Age = 20, Height = 160},
            new Person {Name = "C", Age = 30, Height = 180}
        };

        // IEnumerable 반환
        var result1 = from person in people     // people 안에 있는 데이터에서
                      select person;            // (조건을 충족하는) person의 객체를 추출

        #region 내부적 구조
        // 메서드로 표현 -> SelectAll()
        var result2 = people.Select((person) => person);
        #endregion

        // 따라서 result1으로 foreach문 가능
        foreach (var one in result1) one.Result();
    }

    IEnumerable<Person> SelectAll(List<Person> people)
    {
        foreach (var person in people)
        {
            yield return person;
        }
    }

}
