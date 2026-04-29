using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ㄹ_Ex4 : MonoBehaviour
{
    public interface IDamaged
    {
        public void TakeDamage();
    }

    public class Orc : IDamaged
    {
        public void TakeDamage()
        {
            Debug.Log("Orc Take Damage");
        }
    }

    public class NPC : IDamaged
    {
        public void TakeDamage()
        {
            Debug.Log("NPC Take Damage");
        }
    }

    public class Player
    {
        public void Attack(IDamaged damaged)
        {
            damaged.TakeDamage();
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player player = new Player();

        Orc orc = new Orc();
        NPC npc = new NPC();

        List<IDamaged> damagedList = new List<IDamaged>();
        damagedList.Add(orc);
        damagedList.Add(npc);

        foreach (var item in damagedList)
        {
            player.Attack(item);
        }
    }
}
