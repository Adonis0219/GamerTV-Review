using UnityEngine;
using MyDLL2;
using MyDLL3;

public class DLLTest2 : MonoBehaviour
{
    // 유니티에서 일반적으로 DLL 파일을 불러오고 사용하는 방식

    MyDLL2Class myDLL2 = new MyDLL2Class();
    MyDLL3Class myDLL3 = new MyDLL3Class();

    void Start()
    {
        string str = myDLL2.SetDLL2();
        Debug.Log(str);
        str = myDLL3.SetPlugin();
        Debug.Log(str);
    }
}
