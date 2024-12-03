using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpell : Spell
{
    List<string> spEnemy = new List<string> { "Dragon","Org", "Wizard"};
    
    private void Start()
    {
        Cast();
        Cast("Wywarn");
        Cast("Wywarn", 8);
        RandomSuperPowerCast();
    }
    public override void Cast()
    {
        Debug.Log("Casting an Rock Slide spell!! Kills them all!!");

    }
    public void RandomSuperPowerCast()
    {
       int index  = Random.Range(0, spEnemy.Count);
       Debug.Log($"Casting an Double SuperPower!! Kills {spEnemy[index]}!!");
    }
}
