
using System.Linq;
using UnityEngine;

public class MethodTest3 : MonoBehaviour
{
    int[] numbers = { 1, 2, 3, 4, 5 };

    // select : 요소를 새로운 형태로 반환

    void Start()
    {
        var selectedNumbers = numbers.Select(n => n * n);

        foreach (var item in selectedNumbers)
            Debug.Log(item);
    }
}
