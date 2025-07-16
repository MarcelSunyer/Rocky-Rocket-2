using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    public ParticleSystem particle_1;
    public ParticleSystem particle_2;
    public ParticleSystem particle_3;

    public Rigidbody2D rigidbody2D;

    public float rotationSpeed = 200f;
    public float boostForce = 5f;

    private float rotationInput;
    private float boostInput;

    void FixedUpdate()
    {

        rigidbody2D.rotation -= rotationInput * rotationSpeed * Time.fixedDeltaTime;

        Vector2 direction = transform.up;
        rigidbody2D.AddForce(direction * boostInput * (boostForce / 1000));

        if(boostInput == 0 )
        {
            particle_1.Stop();
            particle_2.Stop();
            particle_3.Stop();  
        }
    }

    public void Rotation(InputAction.CallbackContext context)
    {
        rotationInput = context.ReadValue<Vector2>().x;
    }

    public void Boost(InputAction.CallbackContext context)
    {
        boostInput = context.ReadValue<Vector2>().y;
        particle_1.Play();
        particle_2.Play();
        particle_3.Play();
    }

}
