using System;
using UnityEngine;

public class AttributeTest1 : MonoBehaviour
{
    // Attribute : C# 코드에 추가할 수 있는 메타데이터 -> 컴퓨터가 읽을 수 있는 정보
    // 주석 : 사람이 읽을 수 있는 정보
    // 메타데이터 : 코드 자체에 대한 정보, 데이터 안의 데이터로 Attribute, Reflection을 통해 얻는 정보

    private void Start()
    {
        TestMethod();
    }

    [Obsolete("TestMethod는 더 이상 사용하지 않습니다.")]
    public void TestMethod()
    {
        Debug.Log("Test Method");
    }
}
