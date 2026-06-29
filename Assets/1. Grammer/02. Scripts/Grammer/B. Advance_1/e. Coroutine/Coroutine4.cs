using System.Collections;
using UnityEngine;

public class Coroutine4 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        Debug.Log("1");
        yield return new WaitForSeconds(1);
        // 대기 -> 코드가 메서드의 제어권을 유니티에게 넘김

        // 조건이 달성되면 유니티에게 제어권을 받아와 아래의 코드 실행
        Debug.Log("2");
        yield return new WaitForSeconds(2);
        // 다시 대기

        Debug.Log("3");
    }
}
