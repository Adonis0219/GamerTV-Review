using UnityEngine;

public class DelegateTest5_2 : MonoBehaviour
{
    // 콜백(Callback) : '호출하다'라는 뜻을 가진 단어로, '특정한 시점에 호출되는 함수'를 의미한다.
    // 함수를 먼저 참조하고 나중에 호출하는 방식이 콜백이다. (델리게이트를 이용해서 구현할 수 있다.)

    // 함수를 호출하는 것 Call
    // 함수를 나중에 (Back) 호출한다 (Call)

    class Player
    {
        public void Attack()
        {
            Debug.Log("Player Attack");
        }
    }

    void Start()
    {
        Player player = new Player();
        player.Attack();   // Player 클래스의 Attack 함수 호출
    }
}
