using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChooser : MonoBehaviour
{
    public SpriteRenderer[] skins = new SpriteRenderer[5];

    private GameObject leftSkin;
    private GameObject centerSkin;
    private GameObject rightSkin;

    public Vector3 positionLeft;
    public Vector3 positionCenter;
    public Vector3 positionRight;


    // Start is called before the first frame update
    void Start()
    {
        leftSkin = skins[0].gameObject;
        leftSkin.transform.localPosition = positionLeft;

        centerSkin = skins[1].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.localPosition = positionCenter;

        rightSkin = skins[2].gameObject;
        rightSkin.transform.localPosition = positionRight;

        skins[3].gameObject.SetActive(false);
        skins[4].gameObject.SetActive(false);
        skins[5].gameObject.SetActive(false);
    }
    public void MoveQueueRight()
    {
        for (int i = 0; i < skins.Length; i++)
        {
            if (skins[i].isVisible)
            {
                print("Josemaria");
            }
        
        
        
        }
    }
}
