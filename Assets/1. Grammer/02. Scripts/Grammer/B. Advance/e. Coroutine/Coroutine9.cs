using System.Collections;
using UnityEngine;

public class Coroutine9 : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return null;
    }

    IEnumerator OnCollisionEnter()  // 물리법칙
    {
        yield return null;
    }

    IEnumerator OnMouseEnter()      // 입력
    {
        yield return null;
    }

    IEnumerator OnBecameInvisible() // 렌더링
    {
        yield return null;
    }
}
