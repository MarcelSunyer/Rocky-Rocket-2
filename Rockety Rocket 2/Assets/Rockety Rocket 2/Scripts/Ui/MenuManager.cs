using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public RectTransform canvasFather;

    public Button mainMenu_1;
    public Button mainMenu_2;
    public Button mainMenu_3;

    public Button button_1;
    public Button button_2;
    public Button button_3;
    public Button button_4;
    public Button button_5;
    public Button button_6;
    public Button button_7;
    public Button button_8;
    public Button button_9;
    public Button button_10;
    public Button button_11;
    public Button button_12;
    public Button button_13;

    private float screenWidth;
    private float screenHeight;

    void Start()
    {
        screenWidth = canvasFather.rect.width;
        screenHeight = canvasFather.rect.height;
    }

    public void StartButton()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_1.Select();
    }

    public void SkinButton()
    {
        Vector2 targetPos = new Vector2(screenWidth * 0.018f, 0);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_2.Select();
    }
    public void SettingsButton()
    {
        Vector2 targetPos = new Vector2(-screenWidth * 0.019f, 0);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_3.Select();
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void StartToMain()
    {
        canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
        mainMenu_1.Select();
    }
    public void SkinToMain()
    {
        canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
        mainMenu_2.Select();
    }
    public void OptionsToMain()
    {
        canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
        mainMenu_3.Select();
    }
    
    public void Galaxy_1()
    {
        Vector2 targetPos = new Vector2(screenWidth * 0.030f, -screenHeight * 0.040f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_4.Select();
    }
    public void Galaxy_2()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.052f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_5.Select();
    }
    public void Galaxy_3()
    {
        Vector2 targetPos = new Vector2(-screenWidth * 0.030f, -screenHeight * 0.040f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_6.Select();
    }
    public void Galaxy_4()
    {
        Vector2 targetPos = new Vector2(screenWidth * 0.0355f, -screenHeight * 0.0175f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_7.Select();
    }
    public void Galaxy_5()
    {
        Vector2 targetPos = new Vector2(-screenWidth * 0.0355f, -screenHeight * 0.0175f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_8.Select();
    }
    public void ReturnToTheGalaxy_1()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_9.Select();
    }
    public void ReturnToTheGalaxy_2()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_10.Select();
    }
    public void ReturnToTheGalaxy_3()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_11.Select();
    }
    public void ReturnToTheGalaxy_4()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_12.Select();
    }
    public void ReturnToTheGalaxy_5()
    {
        Vector2 targetPos = new Vector2(0, -screenHeight * 0.020f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_13.Select();
    }
}
