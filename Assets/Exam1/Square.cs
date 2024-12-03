using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;

    private void Start()
    {
        Init("Square");
        side = 12;
        Resize();
        Draw();
        float area = CalculateArea();
        Debug.Log($"{shapeName}'s area has {area} unit^2");
    }

    public override float CalculateArea()
    {
        float area = side * side;
        return area;
    }
    public override void Resize()
    {
        base.Resize();
        Debug.Log($"{shapeName}'s side has {side}");
    }

}
