using System.Linq;
using UnityEngine;

public class MethodTest1 : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    // where : 조건에 맞는 요소들만 필터링

    void Start()
    {
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        var evenNumbers2 = numbers.Where(WhereFunction);

        foreach (var item in evenNumbers)
            Debug.Log(item);
    }

    bool WhereFunction(int n)
    {
        return n % 2 == 0;
    }
}
