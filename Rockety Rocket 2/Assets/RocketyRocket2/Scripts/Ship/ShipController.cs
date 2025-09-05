﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace RocketyRocket2
{
    public class ShipController : MonoBehaviour
    {
        public enum StateShip
        {
            Stop,
            Playing,
            WithoutControls
        }
        public StateShip currentState = StateShip.Playing;
        private Vector2 saveForce = Vector2.zero;
        private Vector2 saveVelocity = Vector2.zero;
        private bool stopToPlay = false;

        public ParticleSystem boost_particle_1;
        public ParticleSystem boost_particle_2;
        public ParticleSystem boost_particle_3;

        public Rigidbody2D rigidbody2D;

        public float rotationSpeed = 200f;
        public float boostForce = 5f;

        private float rotationInput;
        public float boostInput;

        public ParticleSystem destroy_particle_1;
        public ParticleSystem destroy_particle_2;
        public ParticleSystem destroy_particle_3;
       
        public GameObject[] skins;

        void Start()
        {
            for (int i = 0; i < skins.Length; i++)
            {
                if (skins[i].name == "Skin_" + RocketyRocket2Game.Instance.SaveGameManager.Skin)
                {
                    skins[i].SetActive(true);
                }
                else
                {
                    skins[i].SetActive(false);
                }
            }
        }
        void FixedUpdate()
        {
            switch(currentState)
            {
                case StateShip.Stop:
                    StopShip();
                    break;
                case StateShip.Playing:
                    MoveShip();
                    break;
                case StateShip.WithoutControls:
                    break;
            }


            if (boostInput == 0)
            {
                boost_particle_1.Stop();
                boost_particle_2.Stop();
                boost_particle_3.Stop();
            }
        }

        private void MoveShip()
        {
            if(stopToPlay)
            {
                boost_particle_1.gameObject.SetActive(true);
                boost_particle_2.gameObject.SetActive(true);
                boost_particle_3.gameObject.SetActive(false);
                rigidbody2D.velocity = saveVelocity;
                stopToPlay = false;
            }
            rigidbody2D.rotation -= rotationInput * rotationSpeed * Time.fixedDeltaTime;

            Vector2 direction = transform.up;
            saveForce = direction * boostInput * (boostForce / 1000);
            rigidbody2D.AddForce(saveForce);
            saveVelocity = rigidbody2D.velocity;
            
        }

        private void StopShip()
        {
            boost_particle_1.gameObject.SetActive(false);
            boost_particle_2.gameObject.SetActive(false);
            boost_particle_3.gameObject.SetActive(false);
            rotationInput = 0;

            stopToPlay = true;
            boostInput = 0;
            rigidbody2D.AddForce(Vector2.zero);
            rigidbody2D.velocity = Vector2.zero;
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
                for (int i = 0; i < skins.Length; i++)
                {

                    skins[i].SetActive(false);

                }
                destroy_particle_1.Play();
                destroy_particle_2.Play();
                destroy_particle_3.Play();

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


    }
}

