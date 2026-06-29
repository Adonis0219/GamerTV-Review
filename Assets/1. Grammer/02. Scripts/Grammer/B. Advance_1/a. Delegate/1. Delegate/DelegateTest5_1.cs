using UnityEngine;

public class DelegateTest5_1 : MonoBehaviour
{
    class Player
    {
        public enum Buff
        {
            None, Buff1, Buff2
        }

        public Buff _buff;

        public void Attack(Buff buff)
        {
            if (_buff == Buff.Buff1) Buff1();
            else if (_buff == Buff.Buff2) Buff2();
            else NoneBuff();

            Debug.Log("공격");
        }

        void Buff1() {Debug.Log("버프 1");} // 버프 1 계산식
        void Buff2() {Debug.Log("버프 2");} // 버프 2 계산식
        void NoneBuff() {}  // 버프 없을 때
    }

    void Start()
    {
        Player player = new Player();
        player._buff = Player.Buff.Buff1;    // 버프 1 적용
        player.Attack(player._buff);    // 공격 
    }
}
