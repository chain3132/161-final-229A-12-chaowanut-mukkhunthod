using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Circle : Shape
{
    private float raides;
    private void Start()
    {
        base.Draw();
        base.Resize();
        Init("Circle");
        raides = 2; 
        Debug.Log($"Circlearea: {CalculateArea()}from Circle Class");
        Resize();
        Draw();
    }
    public override void Resize()
    {
       
        Debug.Log($"Resizing {shapeName} from Circle Class");
    }
    public override float CalculateArea()
    {
        return Mathf.PI * Mathf.Pow(raides, 2);
    }
    protected override void Draw()
    {
        
        Debug.Log($"Drawing {shapeName} from Circle Class");
    }


}
