using System;
using System.Reflection;
using UnityEngine;

public class DLLTest1 : MonoBehaviour
{
    // DLL(Dynamic Link Library) : 동적 연결 라이브러리 (모듈)
    //                             여러 프로그램에 동적으로 공유할 수 있는 코드, 데이터, 리소스를 의미

    private void Start()
    {
        // DLL 파일 경로 (유니티 프로젝트의 Assets/DLL 폴더에 넣은 DLL 파일 경로)
        string dllPath = Application.dataPath + "/DLL/MyDLL.dll";

        Assembly asm = Assembly.LoadFrom(dllPath);
        Type type = asm.GetType("MyDLL.MyClass");
        object instance = Activator.CreateInstance(type);
        MethodInfo method = type.GetMethod("ReturnString", BindingFlags.NonPublic  | BindingFlags.Instance);

        var str = method.Invoke(instance, null);
        Debug.Log(str);
    }   // -> 유니티가 아닌 C# 프로그램에서 DLL을 리플렉션 하는 방법
        // -> 유니티에서는 DLL을 자체적으로 지원하기 때문에 이렇게 안 해도 됨
        // -> 유니티 DLL 적용 = Plugin 폴더
}
