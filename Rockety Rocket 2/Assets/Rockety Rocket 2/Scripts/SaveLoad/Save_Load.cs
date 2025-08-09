using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Save_Load : MonoBehaviour
{
    public int galaxy;
    public int level;
    public bool firstGame;
    public int skin;

    public bool fullscrean;
    public bool audio_fx;
    public bool audio_music;

    public Button skinChooser;
    // Start is called before the first frame update

    private void Start()
    {
        DontDestroyOnLoad(this);
        galaxy = 1;
        level = 1;

    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        level = data.level;
        galaxy = data.galaxy;
        skin = data.skin;
        firstGame = data.firstGame;
    }

    //If button selected but dont find it when scene is changed

    //If (EventSystem.currentSelectedGameObject == skinChooser)
    //{

    //}

}
