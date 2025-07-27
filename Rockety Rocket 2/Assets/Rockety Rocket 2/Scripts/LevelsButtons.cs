using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsButtons : MonoBehaviour
{
    public GameObject father;

    public Button[] levels = new Button[9];

    public Sprite disabledStateSprite;

    // Update is called once per frame
    void Start()
    {
        for (int i = 1; i < levels.Length; i++)
        {
            SpriteState state = levels[i].spriteState;
            state.disabledSprite = disabledStateSprite;
            levels[i].spriteState = state;
        }

    }
}
