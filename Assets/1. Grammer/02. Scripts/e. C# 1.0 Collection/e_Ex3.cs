using System.Collections;
using UnityEngine;

public class e_Ex3 : MonoBehaviour
{
    // Stack : LIFO (Last In First Out)
    // 매개변수를 모두 object로 받음

    void Start()
    {
        Stack stack = new Stack();
        stack.Push(1);  // 1
        stack.Push(2);  // 1, 2
        stack.Push(3);  // 1, 2, 3

        while (stack.Count > 0)
        {
            Debug.Log(stack.Peek());
        }   // 3, 2, 1

        stack.Pop(); // 1, 2 -> 3
        stack.Pop(); // 1 -> 2
    }
}
