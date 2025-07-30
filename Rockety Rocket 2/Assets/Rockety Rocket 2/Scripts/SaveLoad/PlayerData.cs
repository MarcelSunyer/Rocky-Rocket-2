using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int galaxy;
    public int level;
    public bool firstGame;

    public int skin;

    public bool fullscrean;
    public bool audio_fx;
    public bool audio_music;
    public PlayerData (Save_Load save_load)
    {
        galaxy = save_load.galaxy;
        level = save_load.level;
        firstGame = save_load.firstGame;
        skin = save_load.skin;
        fullscrean = save_load.fullscrean;
        audio_fx = save_load.audio_fx;
        audio_music = save_load.audio_music;

    }
}
 