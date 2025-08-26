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

        [SerializeField] private GameObject restart;


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

            cam.GetComponent<CameraFollow>().enabled = true;
            yield return new WaitForSeconds(2);
            tween = restart.transform.DOMoveY(525, 2);
            tween.Play();

            shipState.currentState = ShipController.StateShip.Playing;


        }

    }
}
