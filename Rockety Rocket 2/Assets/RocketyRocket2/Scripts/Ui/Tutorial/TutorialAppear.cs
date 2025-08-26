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

        [SerializeField] private GameObject cam;

        [SerializeField] private Button startGameplay;


        void Start()
        {
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
            Debug.Log("ASd");
            Tween tween = gameObject.transform.DOMoveY(-500,3);
            tween.Play();
            yield return tween.WaitForCompletion();

            cam.GetComponent<CameraFollow>().enabled = true;
        }

    }
}
