using System;
using UnityEngine;

public static class Calculation
{ 
    public static float deg2rad(float eulerAngle)
    {
        return (float) Math.PI / 180 * eulerAngle - 1.5f * (float)Math.PI;
    }

    public static bool AlmostEquals(this double double1, double double2, double precision)
    {
        return (Math.Abs(double1 - double2) <= precision);
    }

  
}
