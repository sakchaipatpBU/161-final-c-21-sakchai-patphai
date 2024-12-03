using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell Casting. Game Start!!");
    }
    public void Cast(string targetName)
    {
        Debug.Log($"Spell lock on {targetName}.");

    }
    public void Cast(string targetName, int power)
    {
        Debug.Log($"Spell lock on {targetName} with {power} power level.");

    }
}
