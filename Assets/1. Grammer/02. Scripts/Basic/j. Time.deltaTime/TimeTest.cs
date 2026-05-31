using UnityEngine;

public class TimeTest : MonoBehaviour
{
    // Time.deltaTime : 프레임과 프레임 사이의 시간 간격
    // Time.deltaTime을 이용하여 프레임과 프레임 사이의 시간 간격을 구할 수 있다. 
    // 이를 이용하여 프레임과 프레임 사이의 시간 간격을 이용하여 게임 오브젝트를 이동시키거나 회전시키는 등의 작업을 할 수 있다.

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Time.deltaTime, transform.position.y, transform.position.z);
    }
}
