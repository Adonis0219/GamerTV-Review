using UnityEngine;

namespace Command
{
    public class MoveCommand : ICommand
    {
        Player _player;
        Vector2Int _dir;
        Vector2Int _prePos;

        public MoveCommand(Player player, Vector2Int dir)
        {
            _player = player;
            _dir = dir;
        }

        public void Execute()
        {
            //_prePos = _player.Position;
            //_player.Move(_dir);
        }

        public void Undo()
        {
            //_player.Move(_prePos - _player.Position);
        }
    }
}
