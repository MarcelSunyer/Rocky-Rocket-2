using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChooser : MonoBehaviour
{
    public SpriteRenderer[] skins = new SpriteRenderer[5];

    private GameObject leftSkin;
    private GameObject centerSkin;
    private GameObject rightSkin;

    private int leftIndex = 0;
    private int centerIndex = 1;
    private int rightIndex = 2;

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
        rightIndex = centerIndex;
        centerIndex = leftIndex;
        leftIndex = leftIndex - 1;

        if(leftIndex < 0) 
        {
            leftIndex = 5;
        }

        leftSkin = skins[leftIndex].gameObject;
        leftSkin.transform.localPosition = positionLeft;
        leftSkin.gameObject.SetActive(true);

        centerSkin = skins[centerIndex].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.localPosition = positionCenter;

        rightSkin.gameObject.SetActive(false);
        rightSkin = skins[rightIndex].gameObject;
        rightSkin.transform.localPosition = positionRight;
        rightSkin.transform.localScale /= 1.5f;

    }

    public void MoveQueueLeft()
    {
        leftIndex = centerIndex;
        centerIndex = rightIndex;
        rightIndex = rightIndex + 1;

        if (rightIndex > 5)
        {
            rightIndex = 0;
        }

        leftSkin.gameObject.SetActive(false);
        leftSkin = skins[leftIndex].gameObject;
        leftSkin.transform.localPosition = positionLeft;
        leftSkin.transform.localScale /= 1.5f;


        centerSkin = skins[centerIndex].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.localPosition = positionCenter;


        rightSkin = skins[rightIndex].gameObject;
        rightSkin.transform.localPosition = positionRight;
        rightSkin.gameObject.SetActive(true);

    }
}
