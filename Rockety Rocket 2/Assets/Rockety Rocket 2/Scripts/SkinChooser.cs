using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
        leftSkin.transform.DOLocalMove(positionLeft, 0.4f);

        centerSkin = skins[1].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.DOLocalMove(positionCenter, 0.4f);

        rightSkin = skins[2].gameObject;
        rightSkin.transform.DOLocalMove(positionRight, 0.4f);

        skins[3].gameObject.SetActive(false);
        skins[4].gameObject.SetActive(false);
        skins[5].gameObject.SetActive(false);
    }
    
    //Todo: Add the hiden ships on a place to make  arotation, like in the basball;
        
    public void MoveQueueRight()
    {
        rightIndex = centerIndex;
        centerIndex = leftIndex;
        leftIndex = leftIndex - 1;

        if(leftIndex < 0) 
        {
            leftIndex = 5;
        }
        leftSkin.transform.localPosition = positionLeft;
        leftSkin = skins[leftIndex].gameObject;
        leftSkin.transform.DOLocalMove(positionLeft,0.4f);
        leftSkin.gameObject.SetActive(true);

        centerSkin = skins[centerIndex].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.DOLocalMove(positionCenter, 0.4f);

        rightSkin.gameObject.SetActive(false);
        rightSkin = skins[rightIndex].gameObject;
        rightSkin.transform.DOLocalMove(positionRight, 0.4f);
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
        leftSkin.transform.DOLocalMove(positionLeft,0.4f);
        leftSkin.transform.localScale /= 1.5f;


        centerSkin = skins[centerIndex].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.DOLocalMove(positionCenter, 0.4f);


        rightSkin = skins[rightIndex].gameObject;
        rightSkin.transform.DOLocalMove(positionRight, 0.4f);
        rightSkin.gameObject.SetActive(true);


    }
}
