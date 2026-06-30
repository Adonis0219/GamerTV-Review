using UnityEngine;

public class LINQTest0_1 : MonoBehaviour
{
    class Person
    {
        // 겨우 두개의 변수를 할당하기 위해 생성자가 많이 필요함 -> 0_2.ccs 참조
        public string _name;
        public int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(string name)
        {
            _name = name;
        }

        public Person(int age)
        {
            _age = age;
        }

        public Person()
        {
            _name = string.Empty;
            _age = 0;
        }
    }

    void Start()
    {

    }
}