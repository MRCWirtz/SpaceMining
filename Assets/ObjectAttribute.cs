using System;
using UnityEngine;

public class ObjectAttribute : MonoBehaviour
{
    public bool isPlanet;
    public float resources;

    void Awake()    // Always called first (before all Start() functions)
    {
        // Set mass depending on radius (world size) and density (depending on physics)
        float radius = transform.localScale.x / 2;
        if (GetComponent<ObjectAttribute>().isPlanet)
            GetComponent<Rigidbody>().mass = Physics.densityPlanet * (float) Math.Pow(radius, 3);
        else
            GetComponent<Rigidbody>().mass = Physics.densityStar * (float) Math.Pow(radius, 3);
    }
}
