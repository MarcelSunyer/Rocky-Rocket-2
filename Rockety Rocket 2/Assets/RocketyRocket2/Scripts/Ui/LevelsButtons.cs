using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RocketyRocket2
{
    public class LevelsButtons : MonoBehaviour
    {

        public int updateNumber;
        public bool updateBool = false;
        public GameObject father;

        public Button[] levels = new Button[9];

        public Image[] disabledStateSprite = new Image[9];

        // Update is called once per frame
        void Start()
        {
            for (int i = 1; i < levels.Length; ++i)
            {
                disabledStateSprite[i].color = Color.grey;

                levels[i].enabled = false;
            }

        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                UpdateLevels(updateNumber - 1);
            }
        }
        void UpdateLevels(int number)
        {

            for (int i = number; i >= 0; --i)
            {
                levels[i].enabled = true;
                disabledStateSprite[i].color = Color.white;
            }

        }
    }
}
