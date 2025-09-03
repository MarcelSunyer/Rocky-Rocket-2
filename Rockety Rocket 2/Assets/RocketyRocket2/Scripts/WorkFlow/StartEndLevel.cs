using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class StartEndLevel : MonoBehaviour
    {
        [SerializeField] private GameObject upImage;
        [SerializeField] private GameObject downImage;

        [SerializeField] private bool isTutorial;
        [SerializeField] private CameraFollow cameraFollow;

        [SerializeField] private SpriteRenderer arrow;
        [SerializeField] private SpriteRenderer goal;
        private void Start()
        {
            arrow.enabled = false;
            goal.enabled = false;
            StartCoroutine(OpenAnim());
        }

        private IEnumerator Test()
        {
            OpenAnim();
            yield return new WaitForSeconds(4);
            CloseAnim();
        }

        private IEnumerator OpenAnim()
        {
            Tween upTween = upImage.transform.DOMoveY(2000, 3);
            Tween downTween = downImage.transform.DOMoveY(-900, 3);
            upTween.Play();
            downTween.Play();

            if(!isTutorial)
            {
                yield return new WaitForSeconds(2);
                cameraFollow.enabled = true;

            }

        }
        public void CloseAnim()
        {
            Tween upTween = upImage.transform.DOMoveY(400, 3);
            Tween downTween = downImage.transform.DOMoveY(200, 3);
            upTween.Play();
            downTween.Play();
        }
    }
}
