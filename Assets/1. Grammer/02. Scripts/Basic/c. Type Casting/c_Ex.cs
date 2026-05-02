using System.Diagnostics;
using UnityEngine;

public class c_Ex : MonoBehaviour
{
    Stopwatch stopwatch = new Stopwatch();

    private void Start()
    {
        Int();
        Float();
    }

    void Int()
    {
        int num1 = 0;

        stopwatch.Start();

        for (int i = 0; i < 10_000_000; i++)
            num1 += 1;

        stopwatch.Stop();

        UnityEngine.Debug.Log($"int : {stopwatch.ElapsedMilliseconds}ms");
    }

    void Float()
    {
        float num2 = 0;

        stopwatch.Start();

        for (int i = 0; i < 10_000_000; i++)
            num2 += 1;

        stopwatch.Stop();

        UnityEngine.Debug.Log($"float : {stopwatch.ElapsedMilliseconds}ms");
    }
}

