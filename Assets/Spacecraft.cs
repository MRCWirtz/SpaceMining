using UnityEngine;
using System;

public class Spacecraft : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public static float RotateSpeed = 100f;
    public static float acceleration = 20;
    public float acc;
    public bool isTurbo = false;
    public Vector3 rotation = new Vector3(0f, 0f, 1f);
    public Sprite sprite;
    public Sprite spriteTurbo;
    public Sprite spriteAcceleration;
    public void SetFuelLevel(double newFuelLevel) { fuelLevel = (float) Math.Max(0f, newFuelLevel) ; }
    public float GetFuelLevel() { return this.fuelLevel; }
    private float fuelLevel = 1f;
    private float fuelConsTurbo = 0.0005f;
    private float fuelConsDef = 0.0001f;

    void Update () {

        this.GetComponent<SpriteRenderer>().sprite = sprite;

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
        if (Input.GetKey(KeyCode.W) & GetFuelLevel() > 0)
        {
            if (isTurbo)
            {
                SetFuelLevel(GetFuelLevel() - fuelConsTurbo);
                acc = 3 * acceleration;
                this.GetComponent<SpriteRenderer>().sprite = spriteTurbo;
            }
            else
            {
                SetFuelLevel(GetFuelLevel() - fuelConsDef);
                acc = acceleration;
                this.GetComponent<SpriteRenderer>().sprite = spriteAcceleration;
            }
            float xacc = acc * (float)Math.Cos(Calculation.deg2rad(transform.localEulerAngles.z));
            float yacc = acc * (float)Math.Sin(Calculation.deg2rad(transform.localEulerAngles.z));
            rb.AddForce(new Vector2(xacc * Time.deltaTime, yacc * Time.deltaTime));
        }  
    }

    void OnCollisionEnter() {
        FindObjectOfType<GameManager>().GameOver();
    }
}
