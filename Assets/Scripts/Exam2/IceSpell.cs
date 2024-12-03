using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Goblin");
        Cast("Goblin",10);
    }

    public override void Cast()
    {
        
        Debug.Log("Casting an Ice shard spell!! Freeze the enemy!!");
    }
}
