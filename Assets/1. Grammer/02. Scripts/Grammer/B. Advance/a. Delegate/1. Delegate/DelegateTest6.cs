using UnityEngine;

public class DelegateTest6 : MonoBehaviour
{
    class Player
    {
        private delegate void BuffDelegate();    // 버프 계산식 델리게이트 선언

        private BuffDelegate _buffDelegate;   // 버프 계산식 델리게이트 변수 선언
        public enum Buff
        {
            None, Buff1, Buff2
        }

        private Buff _buff;

        public Buff _Buff
        {
            get { return _buff; }
            set
            {
                if (_buff == value) return;   // 버프가 바뀌지 않았다면 계산식 변경하지 않음

                _buff = value;

                if (_buff == Buff.Buff1) _buffDelegate = Buff1;    // 버프 1 계산식 대입
                else if (_buff == Buff.Buff2) _buffDelegate = Buff2;   // 버프 2 계산식 대입
                else _buffDelegate = NoneBuff;    // 버프 없을 때 계산식 대입
            }
        }

        public void Attack()
        {
            _buffDelegate.Invoke();   // 버프 계산식 호출
            Debug.Log("공격");  // 공격
        }

        void Buff1() {Debug.Log("버프 1");} // 버프 1 계산식
        void Buff2() {Debug.Log("버프 2");} // 버프 2 계산식
        void NoneBuff() {}  // 버프 없을 때 계산식

        void Start()
        {
            Player player = new Player();
            player._Buff = Buff.Buff1;    // 버프 1 적용
            player.Attack();    // 공격
        }
    }
}
