using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public static CarController instance;

    public float fuel = 1f;
    public float fuelConsumption = 0.1f;

    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;

    public float speed = 150f;
    public float carTorque = 10f;

    private float movement;

    public Image fuelImage;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        fuelImage.fillAmount = fuel;
    }

    void FixedUpdate()
    {
        if (fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            carRigidbody.AddTorque(movement * carTorque * Time.fixedDeltaTime);

            fuel -= fuelConsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;
        }
    }
}
