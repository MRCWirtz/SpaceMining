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
    private float fuelLevel = 1f;
    private float fuelConsTurbo = 0.01f;
    private float fuelConsDef = 0.001f;

    public void setFuelLevel(double newFuelLevel) { Math.Max(0, this.fuelLevel = (float)newFuelLevel); }
    public float getFuelLevel() { return this.fuelLevel; }

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
        if (Input.GetKey(KeyCode.W))
        {
            if (isTurbo)
            {
                acc = 3 * acceleration;
                setFuelLevel(getFuelLevel() - fuelConsTurbo);
            }
            else
            {
                setFuelLevel(getFuelLevel() - fuelConsDef);
                acc = acceleration;
            }
            float xacc = acc * (float)Math.Cos(Calculation.deg2rad(transform.localEulerAngles.z));
            float yacc = acc * (float)Math.Sin(Calculation.deg2rad(transform.localEulerAngles.z));
            rb.AddForce(new Vector2(xacc * Time.deltaTime, yacc * Time.deltaTime));
        }
        
    }

    void OnCollisionEnter() {
        
    }
}
