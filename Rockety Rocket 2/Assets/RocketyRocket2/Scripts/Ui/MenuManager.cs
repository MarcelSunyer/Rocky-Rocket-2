using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


namespace RocketyRocket2
{
    public class MenuManager : MonoBehaviour
    {
        public RectTransform canvasFather;

        public Button GoToGalaxyScreen;
        public Button BackStart;
        public Button Skins;
        public Button BackSkin;
        public Button Settings;
        public Button BackSettings;

        private float screenWidth;
        private float screenHeight;

        private void Start()
        {
            screenWidth = canvasFather.rect.width;
            screenHeight = canvasFather.rect.height;

            //Start
            GoToGalaxyScreen.onClick.AddListener(StartButton);
            BackStart.onClick.AddListener(StartToMain);

            //Skin
            Skins.onClick.AddListener(SkinButton);
            BackStart.onClick.AddListener(SkinToMain);

            //Settings
            Settings.onClick.AddListener(SettingsButton);
            BackSettings.onClick.AddListener(SettingsToMain);

        }

        public void StartButton()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            BackStart.Select();
        }

        public void SkinButton()
        {
            Vector2 targetPos = new Vector2(screenWidth * 0.018f, 0);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            BackSkin.Select();
            
        }
        public void SettingsButton()
        {
            Vector2 targetPos = new Vector2(-screenWidth * 0.019f, 0);
            canvasFather.DOAnchorPos(targetPos, 1.34f);
            //button_3.Select();
        }
        public void Quit()
        {
            Application.Quit();
        }

        public void StartToMain()
        {
            canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
            //Start.Select();
        }
        public void SkinToMain()
        {
            canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
            Skins.Select();
        }
        public void SettingsToMain()
        {
            canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
            Settings.Select();
        }

        //public void Galaxy_1()
        //{
        //    Vector2 targetPos = new Vector2(screenWidth * 0.030f, -screenHeight * 0.040f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_4.Select();
        //}
        //public void Galaxy_2()
        //{
        //    Vector2 targetPos = new Vector2(0, -screenHeight * 0.052f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_5.Select();
        //}
        //public void Galaxy_3()
        //{
        //    Vector2 targetPos = new Vector2(-screenWidth * 0.030f, -screenHeight * 0.040f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_6.Select();
        //}
        //public void Galaxy_4()
        //{
        //    Vector2 targetPos = new Vector2(screenWidth * 0.0355f, -screenHeight * 0.0175f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_7.Select();
        //}
        //public void Galaxy_5()
        //{
        //    Vector2 targetPos = new Vector2(-screenWidth * 0.0355f, -screenHeight * 0.0175f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_8.Select();
        //}
        //public void ReturnToTheGalaxy_1()
        //{
        //    Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_9.Select();
        //}
        //public void ReturnToTheGalaxy_2()
        //{
        //    Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_10.Select();
        //}
        //public void ReturnToTheGalaxy_3()
        //{
        //    Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_11.Select();
        //}
        //public void ReturnToTheGalaxy_4()
        //{
        //    Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_12.Select();
        //}
        //public void ReturnToTheGalaxy_5()
        //{
        //    Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        //    canvasFather.DOAnchorPos(targetPos, 1.34f);
        //    button_13.Select();
        //}
    }
}
