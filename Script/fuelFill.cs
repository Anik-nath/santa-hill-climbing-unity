using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelFill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CarController.instance.fuel = 1f;
            Destroy(gameObject);
        }
    }
}
