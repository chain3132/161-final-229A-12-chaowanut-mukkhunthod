using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Spell-Casting Simulation Started!! from base class ");
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log("Casting a generic spell!! ");
    }
    public void Cast(string target) { Debug.Log($"casting a spell on target: {target}"); }
    public void Cast(string target,int level) { Debug.Log($"casting a spell on target: {target}! with power level :{level}"); }
}
