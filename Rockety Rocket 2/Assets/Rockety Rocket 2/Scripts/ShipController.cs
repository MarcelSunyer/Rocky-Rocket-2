using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float rotationSpeed = 200f;
    public float boostForce = 5f;

    private float rotationInput;
    private float boostInput;

    void FixedUpdate()
    {
        // Rotación
        rigidbody2D.rotation -= rotationInput * rotationSpeed * Time.fixedDeltaTime;

        // Boost hacia donde apunta el ship
        Vector2 direction = transform.up;
        rigidbody2D.AddForce(direction * boostInput * (boostForce / 1000));
    }

    public void Rotation(InputAction.CallbackContext context)
    {
        rotationInput = context.ReadValue<Vector2>().x;
    }

    public void Boost(InputAction.CallbackContext context)
    {
        boostInput = context.ReadValue<Vector2>().y;
    }
}
