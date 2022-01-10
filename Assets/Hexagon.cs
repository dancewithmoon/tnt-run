using System;
using UnityEngine;

public class Hexagon
{
    private const float SqrtOf3 = 1.732f;

    private float _side;
    private float _bigDiagonal;
    private float _littleDiagonal;
    
    public float Side { get => GetSide(); set => _side = value; }
    public float BigDiagonal { get => GetBigDiagonal(); set => _bigDiagonal = value; }
    public float LittleDiagonal { get => GetLittleDiagonal(); set => _littleDiagonal = value; }

    private float GetSide()
    {
        if(_side != 0)
        {
            return _side;
        }
        else if(_bigDiagonal != 0)
        {
            return _bigDiagonal / 2;
        }
        else if(_littleDiagonal != 0)
        {
            return _littleDiagonal / SqrtOf3;
        }

        throw new ArgumentException("There are no data about hexagon!");
    }

    private float GetBigDiagonal()
    {
        if(_bigDiagonal != 0)
        {
            return _bigDiagonal;
        }
        return 2 * Side;
    }

    private float GetLittleDiagonal()
    {
        if(_littleDiagonal != 0)
        {
            return _littleDiagonal;
        }
        return SqrtOf3 * Side;
    }
}

