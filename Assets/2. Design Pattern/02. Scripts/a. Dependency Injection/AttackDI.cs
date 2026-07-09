using DI;
using UnityEngine;

public class AttackDI : MonoBehaviour
{
    public BaseAttack baseAttack;
    public SpecialAttack specialAttack;
    public MagicAttack magicAttack;

    public Player4 player;

    public void Start()
    {
        player.SetAttackType(baseAttack);
        player.Attack();
    }
}
