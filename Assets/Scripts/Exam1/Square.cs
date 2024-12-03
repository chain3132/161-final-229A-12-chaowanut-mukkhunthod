using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side;
    private void Start()
    {
        Init("Circle");
        side = 2;
        Debug.Log($"Squarearea: {CalculateArea()} from Square Class");
        Resize();
        Draw();
    }
    public override float CalculateArea()
    {
        return side * side;
    }
    public override void Resize()
    {
        
        Debug.Log($"Resizing {shapeName} from Square Class");
    }
    protected override void Draw()
    {
       
        Debug.Log($"Drawing {shapeName} from Square Class");
    }

}
