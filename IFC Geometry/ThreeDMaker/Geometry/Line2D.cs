using System;
using System.Collections.Generic;
using System.Numerics;
public class Line2D:List<Vector2>
{
    public bool Close { get; set; }
    private int NextIndex(int i)
    {
        return i < Count - 1?(i + 1): 0;
    }
    private int PrevIndex(int i)
    {
        return i > 1 ? (i - 1) : Count - 1;
    }

    public void Add(float x, float y)
    {
        Add(new Vector2(x, y));
    }
}
