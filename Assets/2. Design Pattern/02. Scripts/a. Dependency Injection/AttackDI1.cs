using DI;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AttackDI1 : MonoBehaviour
{
    public Button baseAtkBt;
    public Button specialAtkBt;
    public Button magicAtkBt;

    public BaseAttack baseAttack;
    public SpecialAttack specialAttack;
    public MagicAttack magicAttack;

    public Player4 player;

    public void Start()
    {
        baseAtkBt.onClick.AddListener(() =>
        {
            player.SetAttackType(baseAttack);
            player.Attack();
        });

        specialAtkBt.onClick.AddListener(() =>
        {
            player.SetAttackType(specialAttack);
            player.Attack();
        });

        magicAtkBt.onClick.AddListener(() =>
        {
            player.SetAttackType(magicAttack);
            player.Attack();
        });
    }
}
