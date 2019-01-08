using UnityEngine;
using System;

public class Spacecraft : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public static float RotateSpeed = 100f;
    public static float acceleration = 10;
    public float acc;
    public bool isTurbo = false;
    public Vector3 rotation = new Vector3(0f, 0f, 1f);

    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            isTurbo = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            isTurbo = false;
        }
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(rotation * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-rotation * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W)) {
            if (isTurbo)
                acc = 3 * acceleration;
            else
                acc = acceleration;
            float xacc = acc * (float) Math.Cos(Calculation.deg2rad(transform.localEulerAngles.z));
            float yacc = acc * (float) Math.Sin(Calculation.deg2rad(transform.localEulerAngles.z));
            rb.AddForce(new Vector2(xacc * Time.deltaTime, yacc * Time.deltaTime));
        }
    }

    void OnCollisionEnter() {
        
    }
}
