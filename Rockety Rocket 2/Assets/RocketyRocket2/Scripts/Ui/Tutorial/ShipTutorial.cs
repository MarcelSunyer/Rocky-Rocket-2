using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketyRocket2
{
    public class ShipTutorial : MonoBehaviour
    {
        public GameObject Ship;
        public float ShipMovement;
        private Vector2 InitialPosition;

        private void Start()
        {
            InitialPosition = Ship.GetComponent<RectTransform>().position;
            StartCoroutine(TutorialShip());
        }
        private IEnumerator TutorialShip()
        {
            while (true)
            {

                Ship.GetComponent<ParticleSystem>().Play();
                Tween tween = Ship.GetComponent<RectTransform>().DOAnchorPosX(ShipMovement, 2.5f);

                tween.Play();
                yield return tween.WaitForCompletion();
                Ship.GetComponent<RectTransform>().position = InitialPosition;
                Ship.GetComponent<ParticleSystem>().Stop();
                yield return new WaitForSeconds(1.5f);
            }
        }
    }
}
