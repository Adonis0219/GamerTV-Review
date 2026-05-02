using UnityEngine;

public class f_Ex1 : MonoBehaviour
{
    public void Copy(int[] source, int[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }

    public void Copy<T>(T[] source, T[] target)
    {
        for (int i = 0; i < source.Length; i++)
            target[i] = source[i];
    }

    public void Start()
    {
        int[] sourceArray = {1, 2, 3, 4, 5 };
        int[] targetArray = new int[sourceArray.Length];

        Copy(sourceArray, targetArray);
        Copy<int>(sourceArray, targetArray);

        string[] sourceStringArray = {"Hello", "World"};
        string[] targetStringArray = new string[sourceStringArray.Length];

        Copy<string>(sourceStringArray, targetStringArray);
    }
}
