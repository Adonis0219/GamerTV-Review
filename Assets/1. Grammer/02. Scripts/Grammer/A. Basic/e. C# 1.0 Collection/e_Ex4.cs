using System.Collections;
using UnityEngine;

public class e_Ex4 : MonoBehaviour
{
    // Queue : FIFO (First In First Out)
    // 매개변수를 모두 object로 받음

    void Start()
    {
        Queue queue = new Queue();

        queue.Enqueue(1);  // 1
        queue.Enqueue(2);  // 1, 2
        queue.Enqueue(3);  // 1, 2, 3

        while (queue.Count > 0)
        {
            Debug.Log(queue.Peek());
        }   // 1, 2, 3

        queue.Dequeue(); // 2, 3 -> 1
        queue.Dequeue(); // 3 -> 2
    }
}
