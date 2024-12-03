using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private float radius;

    private void Start()
    {
        Init("Circle");
        radius = 17f;
        Resize();
        Draw();
        float area = CalculateArea();
        Debug.Log($"{shapeName}'s area has {area} unit^2");
    }
    public override float CalculateArea()
    {
        float area = Mathf.PI*radius*radius;
        return area;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log($"{shapeName}'s radius has {radius}");
    }
}
