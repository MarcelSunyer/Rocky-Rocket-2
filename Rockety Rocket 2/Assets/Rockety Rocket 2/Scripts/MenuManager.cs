using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public GameObject canvasFather;

    public Button button_1;
    public Button button_2;


    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        canvasFather.transform.DOMoveY(-575, 1.34f,true);
        button_2.Select();

    }
    public void SkinButton()
    {
        canvasFather.transform.DOMoveX(1050, 1.34f, false);
        button_1.Select();
    }
    public void SkinToMain()
    {
        canvasFather.transform.DOMoveX(401.5f, 1.34f, false);

    }
    public void SettingsButton()
    {
        canvasFather.transform.DOMoveX(-525, 1.34f, true);
    }

    public void SelectedMap()
    {
        SceneManager.LoadScene("Main Scene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
