using System;
using UnityEngine;

public class ReflectionTest0_0 : MonoBehaviour
{
    // AppDomain : 프로세스 내부에 독립적인 실행환경을 제공해서 서로 충돌하지 않도록 보호
    // Assembly : AppDomain 내부에서 실행되는 코드와 리소스의 집합체, 컴파일된 코드 단위, 프로그램 배포 단위
    // Module : 어셈블리 내의 코드 및 데이터 단위, 하나의 모듈은 하나의 EXE 또는 DLL 파일을 나타낸다

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AppDomain curDom = AppDomain.CurrentDomain; // 현재 실행중인 AppDomain을 가져옴

        foreach (var asm in curDom.GetAssemblies())
        {
            Debug.Log(asm.FullName); // 현재 AppDomain에 로드된 모든 Assembly의 이름을 출력

            foreach (var mod in asm.GetModules())
            {
                Debug.Log(mod.Name); // 각 Assembly에 포함된 모든 Module의 이름을 출력

                foreach (var type in mod.GetTypes())
                {
                    Debug.Log(type.FullName); // 각 Module에 포함된 모든 Type의 이름을 출력
                }
            }
        }
    }
}
