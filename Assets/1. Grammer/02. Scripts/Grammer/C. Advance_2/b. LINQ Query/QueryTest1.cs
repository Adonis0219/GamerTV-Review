using UnityEngine;

public class QueryTest1 : MonoBehaviour
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; } 
    }

    private void Start()
    {
        var p1 = new Person { Name = "A", Age = 10, Height = 150 };

        // 익명 형식(타입) : 클래스(타입)을 미리 정하지 않고 사용할 수 있는 문법
        var p2 = new { Name = "B", Age = 20, Height = 160 };
    }
}
