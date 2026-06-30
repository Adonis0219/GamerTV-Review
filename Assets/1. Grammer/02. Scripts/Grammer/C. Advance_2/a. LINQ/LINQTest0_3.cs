using System.Collections.Generic;
using UnityEngine;

public class LINQTest0_3 : MonoBehaviour
{
    void Start()
    {
        foreach (var one in GetNumber())
        {
            Debug.Log(one);
        }
    }

    IEnumerable<int> GetNumber()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
}
