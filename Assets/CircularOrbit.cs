using System;
using UnityEngine;

public class CircularOrbit : MonoBehaviour
{
    public Transform posCenter;
    public Rigidbody rbCenter;
    float phi;
    float omega;
    float radius;

    void Start()
    {
        Vector2 v1 = posCenter.position;
        Vector2 v2 = transform.position;
        radius = (float) Vector2.Distance(v1, v2);
        float acceleration = Physics.G * rbCenter.mass / (float) Math.Pow(radius, 2f);
        omega = (float) Math.Sqrt(acceleration / radius);

        Vector2 diff = v2 - v1;
        phi = (float) Mathf.Atan2(diff.y, diff.x);
    }

    // Update is called once per frame
    void Update()
    {
        phi += Time.deltaTime * omega;
        Vector2 vCenter = posCenter.position;
        Vector2 relative = new Vector2((float) Math.Cos(phi), (float) Math.Sin(phi));
        transform.position = vCenter + radius * relative;
    }
}
