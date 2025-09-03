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
        private void Start()
        {
            OpenAnim();
            //StartCoroutine(Test());

        }

        private IEnumerator Test()
        {
            OpenAnim();
            yield return new WaitForSeconds(4);
            CloseAnim();
        }

        public void OpenAnim()
        {
            Tween upTween = upImage.transform.DOMoveY(2000, 3);
            Tween downTween = downImage.transform.DOMoveY(-900, 3);
            upTween.Play();
            downTween.Play();

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
