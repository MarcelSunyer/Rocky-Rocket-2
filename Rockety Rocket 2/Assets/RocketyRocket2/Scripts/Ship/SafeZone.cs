using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace RocketyRocket2
{
    public class SafeZone : MonoBehaviour
    {
        public int GalaxyNum = 1;

        public UnityEngine.Color idle;
        public UnityEngine.Color idleColor;

        public float lerpSpeed = 1;
        public bool startUpdateColor = false;

        public ShipController shipController;

        private SpriteRenderer sprite;
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

                if (GalaxyNum == 1)
                    RocketyRocket2Game.Instance.SaveGameManager.Level_Green += 1;
                if (GalaxyNum == 2)
                    RocketyRocket2Game.Instance.SaveGameManager.Level_Blue += 1;
                if (GalaxyNum == 3)
                    RocketyRocket2Game.Instance.SaveGameManager.Level_Purple += 1;
                if (GalaxyNum == 4)
                    RocketyRocket2Game.Instance.SaveGameManager.Level_Orange += 1;
                if (GalaxyNum == 5)
                    RocketyRocket2Game.Instance.SaveGameManager.Level_Red += 1;

                SceneManager.LoadScene("MainMenu");

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
