using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Load : MonoBehaviour
{
    public int galaxy;
    public int level;
    public bool firstGame;
    public int skin;

    public bool fullscrean;
    public bool audio_fx;
    public bool audio_music;
    // Start is called before the first frame update

    private void Start()
    {
        galaxy = 1;
        level = 1;
        Debug.Log(Application.persistentDataPath);
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

}
