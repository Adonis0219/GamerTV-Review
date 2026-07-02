
using System.Linq;
using UnityEngine;

public class MethodTest2 : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    // orderby : 오름차순 정렬, orderby descending : 내림차순 정렬

    void Start()
    {
        var sortedNumbers = numbers.OrderBy(n => n);

        foreach (var item in sortedNumbers)
            Debug.Log(item);
    }
}
