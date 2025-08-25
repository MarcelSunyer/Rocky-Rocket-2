using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketyRocket2
{
    public class SaveGameManager
    {
        public int Level_Green;
        public int Level_Blue;
        public int Level_Purple;
        public int Level_Orange;
        public int Level_Red;
        public int Galaxy;
        public int Skin;

        //public bool FullScrean;
        //public float FxSound;
        //public float Music;

        public void Save()
        {
            PlayerPrefs.SetInt("Level_Green", Level_Green);
            PlayerPrefs.SetInt("Level_Blue", Level_Blue);
            PlayerPrefs.SetInt("Level_Purple", Level_Purple);
            PlayerPrefs.SetInt("Level_Orange", Level_Orange);
            PlayerPrefs.SetInt("Level_Red", Level_Red);

            PlayerPrefs.SetInt("Galaxy", Galaxy);

            PlayerPrefs.SetInt("Skin", Skin);

            PlayerPrefs.Save();
        }

        public void Load() 
        {
            Level_Green = PlayerPrefs.GetInt("Level_Green", 1);
            Level_Blue = PlayerPrefs.GetInt("Level_Blue", 1);
            Level_Purple = PlayerPrefs.GetInt("Level_Purple", 1);
            Level_Orange = PlayerPrefs.GetInt("Level_Orange", 1);
            Level_Red = PlayerPrefs.GetInt("Level_Red", 1);

            Galaxy = PlayerPrefs.GetInt("Galaxy", 1);
            Skin = PlayerPrefs.GetInt("Skin", 0);
        }   


        //PlayerPrefs.SetInt
      
    }
}
