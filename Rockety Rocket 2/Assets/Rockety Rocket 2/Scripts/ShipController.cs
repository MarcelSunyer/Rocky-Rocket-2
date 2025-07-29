using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipController : MonoBehaviour
{
    public ParticleSystem boost_particle_1;
    public ParticleSystem boost_particle_2;
    public ParticleSystem boost_particle_3;

    public Rigidbody2D rigidbody2D;

    public float rotationSpeed = 200f;
    public float boostForce = 5f;

    private float rotationInput;
    public float boostInput;

    public SpriteRenderer ship;

    public ParticleSystem destroy_particle_1;
    public ParticleSystem destroy_particle_2;
    public ParticleSystem destroy_particle_3;

    public int galaxy;
    public int level;
    public bool firstGame;

    public int skin;

    private void Start()
    {
        ship = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {

        rigidbody2D.rotation -= rotationInput * rotationSpeed * Time.fixedDeltaTime;

        Vector2 direction = transform.up;
        rigidbody2D.AddForce(direction * boostInput * (boostForce / 1000));

        if(boostInput == 0 )
        {
            boost_particle_1.Stop();
            boost_particle_2.Stop();
            boost_particle_3.Stop();  
        }
    }

    public void Rotation(InputAction.CallbackContext context)
    {
        rotationInput = context.ReadValue<Vector2>().x;
    }

    public void Boost(InputAction.CallbackContext context)
    {
        boostInput = context.ReadValue<Vector2>().y;
        boost_particle_1.Play();
        boost_particle_2.Play();
        boost_particle_3.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            destroy_particle_1.Play();
            destroy_particle_2.Play();
            destroy_particle_3.Play();

            ship.enabled = false;

            boost_particle_1.gameObject.SetActive(false);
            boost_particle_2.gameObject.SetActive(false);
            boost_particle_3.gameObject.SetActive(false);
            
            collision.gameObject.GetComponent<Collider2D>().enabled = false;

            StartCoroutine(DestroyShip());

        }
    }
    private IEnumerator DestroyShip()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        galaxy = data.galaxy;
        ship = data.spriteRenderer;
        firstGame = data.firstGame;
    }

}
