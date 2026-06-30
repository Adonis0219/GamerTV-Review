using UnityEngine;

public class LINQTest0_2 : MonoBehaviour
{
    // LINQ 사용 -> LINQTest0_2_1.cs
    class Person
    {
        string _name;
        int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        // 자동구현 프로퍼티
        public int Height
        {
            get;
            set;
        }
    }

    void Start()
    {
        Person p1 = new Person();
        Person p2 = new Person { Name = "Nana" };
        Person p3 = new Person { Age = 21 };
        Person p4 = new Person { Name = "Lim", Age = 40, Height = 170 };

        Debug.Log($"Name : {p1.Name}, Age : {p1.Age}, Height : {p1.Height}");
        Debug.Log($"Name : {p2.Name}, Age : {p2.Age}, Height : {p2.Height}");
        Debug.Log($"Name : {p3.Name}, Age : {p3.Age}, Height : {p3.Height}");
        Debug.Log($"Name : {p4.Name}, Age : {p4.Age}, Height : {p4.Height}");
    }
}
