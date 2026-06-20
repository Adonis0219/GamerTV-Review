using System.Collections.Generic;
using UnityEngine;

public class f_Ex5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Stack -> Stack<T>
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        while (stack.Count > 0)
            Debug.Log(stack.Pop()); // 5, 4, 3, 2, 1    
    }
}
