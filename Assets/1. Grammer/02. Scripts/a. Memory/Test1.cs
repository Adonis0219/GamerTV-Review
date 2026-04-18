using UnityEngine;

public class Test1 : MonoBehaviour
{
    
}

public class Test2 : MonoBehaviour
{
    void TestFunction()
    {
        int hp = 10;    // 4byte
        int mp = 20;    // 4byte
        long money = 100_100_100;   // 8byte
    }
}

public class Test3 : MonoBehaviour
{
    static int global;

    void TestPulu()
    {
        global++;
    }

    void TestPulu2()
    {
        global++;
        global++;
    }
}

public class Test4 : MonoBehaviour
{
    private void Start()
    {
        Test();
    }

    void Test()
    {
        int num1 = 1;
        int num2 = 2;

        Debug.Log(num1);
        Debug.Log(num2);

        // Test() 함수가 끝나면 스택 영역에서 num1과 num2는 사라진다(메모리 할당 해제). 
    }
}