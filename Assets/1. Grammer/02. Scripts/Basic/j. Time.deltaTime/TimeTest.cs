using UnityEngine;

public class TimeTest : MonoBehaviour
{
    // Time.deltaTime : 프레임과 프레임 사이의 시간 간격
    // Time.deltaTime을 이용하여 프레임과 프레임 사이의 시간 간격을 구할 수 있다. 
    // 이를 이용하여 프레임과 프레임 사이의 시간 간격을 이용하여 게임 오브젝트를 이동시키거나 회전시키는 등의 작업을 할 수 있다.

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;  // 프레임과 프레임 사이의 시간 간격을 구한다 (Update 함수가 호출되는 시간 간격)
        transform.position = 
        new Vector3(
            transform.position.x, 
            transform.position.y + dt * 1f, 
            transform.position.z);
    }

    // 만약 1초에 10프레임의 속도를 가지고 있는 pc의 경우
    // y축 10
    // Time.deltaTime = 1초 / 10프레임 = 0.1초
    // y축 10 * Time.deltaTime = 10 * 0.1초 = 1

    // 만약 1초에 20프레임의 속도를 가지고 있는 pc의 경우
    // y축 20
    // Time.deltaTime = 1초 / 20프레임 = 0.05초
    // y축 20 * Time.deltaTime = 20 * 0.05초 = 1

    // 사용자의 pc 성능에 상관없이 동일한 퍼포먼스를 보여준다.

    float time = 0f;

    void Move1s()
    {
        time += Time.deltaTime;  // time에 Time.deltaTime을 더한다. (time이 1초가 될 때까지)
        if (time >= 1f)  // time이 1초가 되면
        {
            transform.position = 
            new Vector3(
                transform.position.x, 
                transform.position.y + 1f, 
                transform.position.z);
            time = 0f;  // time을 초기화한다.
        }
    }
}
