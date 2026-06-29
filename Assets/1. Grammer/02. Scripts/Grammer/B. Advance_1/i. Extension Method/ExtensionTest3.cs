using UnityEngine;

public class Player
{
    public void Move()
    {
        Debug.Log("Move");
    }
}

public static class AdvPlayer
{
    // this 대상타입 식별자 -> 확장할 클래스 또는 타입 
    public static void Jump(this Player player)
    {
        Debug.Log("Jump");
    }
}

public class ExtensionTest3 : MonoBehaviour 
{
    private void Start()
    {
        Player player = new Player();
        player.Move();
        player.Jump();
    }
}
