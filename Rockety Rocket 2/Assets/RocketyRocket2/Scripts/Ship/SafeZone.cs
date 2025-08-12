using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

namespace RocketyRocket2
{
    public class SafeZone : MonoBehaviour
    {
        private SpriteRenderer sprite;
        public UnityEngine.Color idle;
        public UnityEngine.Color idleColor;

        public float lerpSpeed = 1;
        public bool startUpdateColor = false;

        public ShipController shipController;

        void Start()
        {
            sprite = GetComponent<SpriteRenderer>();
            if (shipController == null)
            {
                shipController = GameObject.Find("Ship").GetComponent<ShipController>();
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (startUpdateColor)
            {
                StartCoroutine(UpdateColor());
            }

        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.CompareTag("Ship"))
            {

                startUpdateColor = true;

                shipController.rigidbody2D.drag = 5f;
                shipController.boostInput = 0;

                shipController.boost_particle_1.gameObject.SetActive(false);
                shipController.boost_particle_2.gameObject.SetActive(false);
                shipController.boost_particle_3.gameObject.SetActive(false);

                Destroy(shipController);

            }
        }
        private IEnumerator UpdateColor()
        {
            UnityEngine.Color lerpedColor = UnityEngine.Color.white;
            float currentTime = 0;

            while (this.enabled)
            {
                lerpedColor = UnityEngine.Color.Lerp(idle, idleColor, Mathf.PingPong(currentTime += (Time.deltaTime * lerpSpeed / 1), 1));

                sprite.color = lerpedColor;

                yield return new WaitForSeconds(0);
            }

            sprite.color = idle;
        }
    }
}
