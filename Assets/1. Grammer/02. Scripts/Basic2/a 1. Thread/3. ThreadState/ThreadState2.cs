using UnityEngine;

public class ThreadState2 : MonoBehaviour
{
    // 스레드 상태
    // Unstarted : 스레드 생성 후 Start() 메서드가 실행되기 전 상태
    // Running : 스레드가 실행되어 동작 중인 상태
    // Suspended : Thread.Suspend()로 인해 스레드 일시 중단 상태, Thread.Resume() 호출까지 대기
    // WaitSleepJoin : 스레드 일시 중단 상태, 특정 조건까지만 대기
    // Aborted : 스레드 취소 상태
}
