using System;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    // Start is called before the first frame update
    public static float deg2rad(float eulerAngle)
    {
        return (float) Math.PI / 180 * eulerAngle - 1.5f * (float)Math.PI;
    }

}
