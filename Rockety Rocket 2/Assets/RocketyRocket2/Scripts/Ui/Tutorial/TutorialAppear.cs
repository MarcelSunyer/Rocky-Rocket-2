using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class TutorialAppear : MonoBehaviour
    {
        [SerializeField] private ShipController shipState;

        [SerializeField] private GameObject cam;

        [SerializeField] private Button startGameplay;

        [SerializeField] private Image fade;

        void Start()
        {

           shipState.currentState = ShipController.StateShip.Stop;
           cam.GetComponent<CameraFollow>().enabled = false;
           startGameplay.Select();
           startGameplay.onClick.AddListener(StartGamePlay);
        }

        private void StartGamePlay()
        {
            StartCoroutine(HideTutorialAndMove());
        }

        private IEnumerator HideTutorialAndMove()
        {

            Tween tween = gameObject.transform.DOMoveY(-200, 2);
            tween.Play();
            yield return tween.WaitForCompletion();

            tween = fade.DOFade(0f,1f);
            tween.Play();

            cam.GetComponent<CameraFollow>().enabled = true;
            yield return new WaitForSeconds(2);

            shipState.currentState = ShipController.StateShip.Playing;


        }

    }
}
