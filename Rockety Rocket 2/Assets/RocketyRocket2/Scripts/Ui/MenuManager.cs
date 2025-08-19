using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


namespace RocketyRocket2
{
    public class MenuManager : MonoBehaviour
    {
        //Canvas parameters
        public RectTransform canvasFather;
        private float screenWidth;
        private float screenHeight;

        //Start parameters
        public Button GoToGalaxyScreen;
        public Button BackStart;

        public Button Skins;
        public Button BackSkin;

        public Button Settings;
        public Button BackSettings;

        //Galxies Parameters
        public Button MilkyWay;
        public Button MilkyWayBack;

        public Button SagDeg;
        public Button SagDegBack;

        public Button LMC;
        public Button LMCBack;

        public Button SMC;
        public Button SMCBack;

        public Button Messier32;
        public Button Messier32Back;

        private void Start()
        {
            screenWidth = canvasFather.rect.width;
            screenHeight = canvasFather.rect.height;

            //Start
            GoToGalaxyScreen.onClick.AddListener(StartButton);
            BackStart.onClick.AddListener(StartToMain);

            //Skin
            Skins.onClick.AddListener(SkinButton);
            BackSkin.onClick.AddListener(SkinToMain);

            //Settings
            Settings.onClick.AddListener(SettingsButton);
            BackSettings.onClick.AddListener(SettingsToMain);

            //MilkyWay
            MilkyWay.onClick.AddListener(GoMilkyWay);
            MilkyWayBack.onClick.AddListener(MilkyWayToGalaxy);

            //SagDeg
            SagDeg.onClick.AddListener(GoSagDeg);
            SagDegBack.onClick.AddListener(SagDegToGalaxy);

            //LMC
            LMC.onClick.AddListener(GoLMC);
            LMCBack.onClick.AddListener(LMCToGalaxy);

            //SMC
            SMC.onClick.AddListener(GoSMC);
            SMCBack.onClick.AddListener(SMCToGalaxy);

            //Messier32
            Messier32.onClick.AddListener(GoMessier32);
            Messier32Back.onClick.AddListener(Messier32ToGalaxy);

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
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            BackSettings.Select();
        }
        public void Quit()
        {
            Application.Quit();
        }

        public void StartToMain()
        {
            Tween tween = canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
            tween.Play(); 
            GoToGalaxyScreen.Select();
        }
        public void SkinToMain()
        {
            Tween tween = canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
            tween.Play();
            Skins.Select();
        }
        public void SettingsToMain()
        {
            Tween tween = canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
            tween.Play();
            Settings.Select();
        }

        public void GoMilkyWay()
        {
            Vector2 targetPos = new Vector2(screenWidth * 0.030f, -screenHeight * 0.040f);
           
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();

            MilkyWayBack.Select();
        }
        public void MilkyWayToGalaxy()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            MilkyWay.Select();
        }

        public void GoSagDeg()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.052f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            SagDegBack.Select();
        }
        public void SagDegToGalaxy()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            SagDeg.Select();
        }

        public void GoLMC()
        {
            Vector2 targetPos = new Vector2(-screenWidth * 0.030f, -screenHeight * 0.040f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            LMCBack.Select();
        }
        public void LMCToGalaxy()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            LMC.Select();
        }

        public void GoSMC()
        {
            Vector2 targetPos = new Vector2(screenWidth * 0.0355f, -screenHeight * 0.0175f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            SMCBack.Select();
        }
        public void SMCToGalaxy()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            SMC.Select();
        }

        public void GoMessier32()
        {
            Vector2 targetPos = new Vector2(-screenWidth * 0.0355f, -screenHeight * 0.0175f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            Messier32Back.Select();
        }
        public void Messier32ToGalaxy()
        {
            Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
            Tween tween = canvasFather.DOAnchorPos(targetPos, 1.34f);
            tween.Play();
            Messier32.Select();
        }
    }
}
