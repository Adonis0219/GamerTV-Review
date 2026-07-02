using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MethodTest7 : MonoBehaviour
{
    void Start()
    {
        // SelectMany : 단일 컬렉션으로 만듦

        // 각 학생이 들은 과목 리스트
        List<List<string>> studentSubjects = new List<List<string>>
        {
            new List<string> { "Math", "Science" },
            new List<string> { "History", "Math" },
            new List<string> { "Science", "Art" }
        };

        // 모든 과목을 하나의 리스트로 평탄화
        var allSubjects = studentSubjects.SelectMany(subjects => subjects).Distinct();

        // 결과 출력
        Debug.Log("All Subjects:");
        foreach (var subject in allSubjects)
            Debug.Log(subject);
    }
}
