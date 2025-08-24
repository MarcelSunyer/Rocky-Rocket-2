using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class UnlockedGalaxies : MonoBehaviour
    {
        public Button[] Galaxies;
        public Button UpdateStateGalaxies;

        public int galaxiesLocked = 1;

        private void Start()
        {
            UpdateStateGalaxies.onClick.AddListener(UnlockGalxies);
        }

        private void UnlockGalxies()
        {
            for (int i = Galaxies.Length - 1; i >= galaxiesLocked; --i)
            {
                Galaxies[i].image.color = Color.black;
                Galaxies[i].GetComponentInChildren<SpriteRenderer>().color = Color.black;

                Galaxies[i].interactable = false;

            }
        }

    }
}
