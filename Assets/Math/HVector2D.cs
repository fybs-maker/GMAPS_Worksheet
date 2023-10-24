using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//[Serializable]
public class HVector2D
{
    public float x, y;
    public float h;

    public HVector2D(float _x, float _y)
    {
        x = _x;
        y = _y;
        h = 1.0f;
    }

    public HVector2D(Vector2 _vec)
    {
        x = _vec.x;
        y = _vec.y;
        h = 1.0f;
    }

    public HVector2D()
    {
        x = 0;
        y = 0;
        h = 1.0f;
    }

    // public static HVector2D operator +(HVector2Dx, HVector2Dy)
    // {
        // sums = x + y;
        // return sums;
    // }

    // public static HVector2D operator -(/*???*/)
    // {

    // }

    // public static HVector2D operator *(/*???*/)
    // {

    // }

    // public static HVector2D operator /(/*???*/)
    // {

    // }

    // public float Magnitude()
    // {

    // }

    // public void Normalize()
    // {

    // }

    // public float DotProduct(/*???*/)
    // {

    // }

    // public HVector2D Projection(/*???*/)
    // {

    // }

    // public float FindAngle(/*???*/)
    // {

    // }


    public Vector2 ToUnityVector2()
    {
        return Vector2.(x,y); 
    }

    public Vector3 ToUnityVector3()
    {
        return Vector2.(x,y,0);
    }

    // public void Print()
    // {

    // }
}
