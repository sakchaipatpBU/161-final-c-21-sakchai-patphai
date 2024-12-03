using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Lone Wolf");
        Cast("Lone Wolf", 13);
        Cast("Lone Wolf", 13, 9.423f);
    }
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Player is casting Dark spell, target will be blind");
    }
    public void Cast(string targetName, int power, float duration)
    {
        Debug.Log($"Spell lock on {targetName} with {power} power level and time {duration} sec.");
    }
}
