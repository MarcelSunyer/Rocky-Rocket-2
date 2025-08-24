using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RocketyRocket2
{
    public class SaveGameManager
    {
        public int[] Level = new int[4];
        public int Galaxy;
        public int Skin;

        //public bool FullScrean;
        //public float FxSound;
        //public float Music;

        public void Save()
        {
            for (int i = 0; i < 4; i++)
            {               
                PlayerPrefs.SetInt("Level", Level[i]);

            }   

            PlayerPrefs.SetInt("Galaxy", Galaxy);

            PlayerPrefs.SetInt("Skin", Skin);

            PlayerPrefs.Save();


        }

        public void Load() 
        {
            for (int i = 0; i < 4; ++i)
            {
                Level[i] = PlayerPrefs.GetInt("Level", 1);
            }

            Galaxy = PlayerPrefs.GetInt("Galaxy", 1);

            Skin = PlayerPrefs.GetInt("Skin", 0);
        }


        //PlayerPrefs.SetInt
      
    }
}
