using UnityEngine;

namespace Template
{
    public class Test : MonoBehaviour
    {
        [SerializeField] PlayerBase _playerBase;

        private void Start()
        {
            _playerBase.Idle();
            _playerBase.Move();
            _playerBase.MoveTarget();
            _playerBase.Attack();
        }
    }
}
