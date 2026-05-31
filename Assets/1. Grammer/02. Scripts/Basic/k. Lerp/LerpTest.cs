using UnityEngine;

public class LerpTest : MonoBehaviour
{
    Vector3 startPos;   // 시작값 a
    Vector3 targetPos = new Vector3(0, 5, 0); // 목표값 b

    float curTime = 0; // a와 b 사이를 선형보간하는 t값
    float moveTime = 2; // a에서 b로 이동하는데 걸리는 시간

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; // 시작값 a는 현재 위치로 설정
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime; // t값을 시간에 따라 증가시킴

        transform.position = Vector3.Lerp(startPos, targetPos, curTime / moveTime); // Lerp 함수를 사용하여 위치를 보간
    }
}
