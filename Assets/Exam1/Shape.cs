using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;

    public void Init(string name)
    {
        this.shapeName = name;
    }

    public abstract float CalculateArea();
    public virtual void Resize()
    {
        Debug.Log($"{shapeName} is resizing shape");
    }
    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}.");
    }
}
