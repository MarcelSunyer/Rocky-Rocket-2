using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private Button[] Levels;
        [SerializeField] private int galaxy = 1;

        private void Start()
        {
            for (int i = 0; i < Levels.Length; i++)
            {
                string levelName = Levels[i].name +"_"+ galaxy.ToString();
                Levels[i].onClick.AddListener(()=> LoadLevel(levelName));
            }
        }

        private void LoadLevel(string levelName)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
