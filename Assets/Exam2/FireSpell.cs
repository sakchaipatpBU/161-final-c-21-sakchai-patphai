using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Big Butterfly");
        Cast("Big Butterfly", 7);
    }
    public override void Cast()
    {
        base.Cast();
        Debug.Log($"Player is casting Fire spell, target will be burn");
    }
}
