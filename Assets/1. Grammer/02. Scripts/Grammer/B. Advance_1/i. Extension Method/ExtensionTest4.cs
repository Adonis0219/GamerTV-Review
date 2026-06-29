using UnityEngine;


public class ExtensionTest4 : MonoBehaviour 
{
    private void Start()
    {
        Player player = new Player();
        player.Move();
        player.Jump();
    }
}
