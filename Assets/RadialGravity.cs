using System;
using UnityEngine;

public class RadialGravity : MonoBehaviour
{
    public Transform posFallingObject;
    public Rigidbody rbFallingObject;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 v1 = posFallingObject.position;
        Vector2 v2 = transform.position;
        Rigidbody rb = GetComponent<Rigidbody>();
        float distance_3 = (float) Math.Pow(Vector2.Distance(v1, v2), 3f);
        rbFallingObject.AddForce(Time.deltaTime * Physics.G *  rb.mass * (v2 - v1) / distance_3, ForceMode.VelocityChange);
    }
}