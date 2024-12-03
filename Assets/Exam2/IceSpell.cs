using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("tiny mouse");
        Cast("tiny mouse", 10);
    }
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Player is casting Ice spell, target will be freeze");
    }
}
