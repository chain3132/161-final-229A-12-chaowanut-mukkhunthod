using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("slime");
        Cast("slime", 5);
    }
    public override void Cast()
    {
        
        Debug.Log("casting a FireBall Spell!! Burn them all");

    }
    
}
