using System;
using UnityEngine;

public class GravitySpaceShip : MonoBehaviour
{
    public Transform pos_spacecraft;
    public Rigidbody2D rb_spacecraft;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 v1 = pos_spacecraft.position;
        Vector2 v2 = transform.position;
        rb = GetComponent<Rigidbody>();
        rb_spacecraft.AddForce(rb.mass * (v2 - v1) / (float) Math.Pow(Vector2.Distance(v1, v2), 3f));
    }
}
