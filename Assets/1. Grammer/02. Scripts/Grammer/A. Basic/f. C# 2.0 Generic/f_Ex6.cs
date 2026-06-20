using System.Collections.Generic;
using UnityEngine;

public class f_Ex6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Queue -> Queue<T>    
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");
        queue.Enqueue("D");
        queue.Enqueue("E");

        while (queue.Count > 0)
            Debug.Log(queue.Dequeue()); // A, B, C, D, E
    }
}
