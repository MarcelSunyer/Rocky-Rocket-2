using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class PlanetLevelManager : MonoBehaviour
    {
        public int LevelsOperative = 1;
        public Color BlockedLevel;

        [SerializeField] private Button[] levels;
        [SerializeField] private Button updateLevels;

        private bool canBePlayed;

        private void Start()
        {
            updateLevels.onClick.AddListener(UpdateLevels);
        }
        private void UpdateLevels()
        {
            for (int i = levels.Length - 1; i >= LevelsOperative; --i)
            {
                levels[i].image.color = BlockedLevel;
                levels[i].GetComponentInChildren<TextMeshProUGUI>().color = BlockedLevel;
                levels[i].enabled = false;
                levels[i].interactable = false;
            }

        }
    }
}
