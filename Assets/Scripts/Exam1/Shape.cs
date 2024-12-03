using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    protected string shapeName;
    private void Start()
    {
        Resize();
        Draw();
    }
    public void Init(string shapeName)
    {
        this.shapeName = shapeName;
    }
    public abstract float CalculateArea();
    public virtual void Resize()
    {
        Debug.Log("Resizing Shape from base class");
    }
    protected virtual void Draw() { Debug.Log("Drawing Shape from base class"); }
        
}
