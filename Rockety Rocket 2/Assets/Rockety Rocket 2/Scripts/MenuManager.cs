using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public RectTransform canvasFather;

    public Button button_1;
    public Button button_2;
    public Button button_3;

    public Button button_4;

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

    public void SkinToMain()
    {
        canvasFather.DOAnchorPos(Vector2.zero, 1.34f);
    }
    public void Galaxy_1()
    {
        Vector2 targetPos = new Vector2(screenWidth * 0.030f, -screenHeight * 0.040f);
        canvasFather.DOAnchorPos(targetPos, 1.34f);
        button_4.Select();
    }
}
