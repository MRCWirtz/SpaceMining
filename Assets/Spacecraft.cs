using UnityEngine;
using System;

public class Spacecraft : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public static float RotateSpeed = 100f;
    public static float acceleration = 10;
    public bool isTurbo = false;
    public Vector3 rotation = new Vector3(0f, 0f, 1f);

    void Update () {
        if (Input.GetKeyDown(KeyCode.SHIFT)) {
            isTurbo = true;
        }
        if (Input.GetKeyUp(KeyCode.SHIFT)) {
            isTurbo = false;
        }
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(rotation * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-rotation * RotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W)) {
            if (isTurbo)
                float acc = 3 * acceleration;
            else
                float acc = acceleration;
            float xacc = acc * (float) Math.Cos(Calculation.deg2rad(transform.localEulerAngles.z));
            float yacc = acc * (float) Math.Sin(Calculation.deg2rad(transform.localEulerAngles.z));
            rb.AddForce(new Vector2(xacc * Time.deltaTime, yacc * Time.deltaTime));
        }
    }
}
