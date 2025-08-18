using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class PlanetLevelManager : MonoBehaviour
    {
        [SerializeField] private Button[] levels;
        private bool canBePlayed;
        public int levelsOperative;

        private void Update()
        {
            for (int i = 0; i < levelsOperative; i++)
            {
                levels[i].image.color = Color.white;

                levels[i].enabled = true;
            }

        }
    }
}
