﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SkinChooser : MonoBehaviour
{
    public SpriteRenderer[] skins = new SpriteRenderer[5];

    private GameObject l_leftSkin;
    private GameObject leftSkin;

    private GameObject centerSkin;
    private GameObject c_centerSkin;

    private GameObject rightSkin;
    private GameObject r_rightSkin;

    private int leftIndex = 0;
    private int centerIndex = 1;
    private int rightIndex = 2;

    public Vector3 position_L_Left;
    public Vector3 positionLeft;

    public Vector3 positionCenter;
    public Vector3 position_C_Center;

    public Vector3 positionRight;
    public Vector3 position_R_Right;


    int safeIndexRight = 3;
    int safeIndexCenter = 4;
    int safeIndexLeft = 5;


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

        r_rightSkin = skins[3].gameObject;
        r_rightSkin.transform.DOLocalMove(position_R_Right, 0.4f);

        c_centerSkin = skins[4].gameObject;
        c_centerSkin.transform.DOLocalMove(position_C_Center, 0.4f);

        l_leftSkin = skins[5].gameObject;
        l_leftSkin.transform.DOLocalMove(position_L_Left, 0.4f);

        //skins[3].gameObject.SetActive(false);
        //skins[4].gameObject.SetActive(false);
        //skins[5].gameObject.SetActive(false);
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

        if (rightIndex > 5)
        {
            rightIndex = 0;
        }

        safeIndexLeft = (leftIndex - 1 == -1) ? 5 : (leftIndex - 1);
        l_leftSkin = skins[safeIndexLeft].gameObject;
        l_leftSkin.transform.DOLocalMove(position_L_Left, 0.4f);

        leftSkin.transform.localPosition = positionLeft;
        leftSkin = skins[leftIndex].gameObject;
        leftSkin.transform.DOLocalMove(positionLeft,0.4f);
        FadeIn(skins[leftIndex]);

                centerSkin = skins[centerIndex].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.DOLocalMove(positionCenter, 0.4f);


        rightSkin = skins[rightIndex].gameObject;
        rightSkin.transform.DOLocalMove(positionRight, 0.4f);
        rightSkin.transform.localScale /= 1.5f;


        safeIndexRight = (rightIndex + 1 == 6) ? 0 : (rightIndex + 1);
        FadeOut(skins[safeIndexRight]);
        r_rightSkin = skins[safeIndexRight].gameObject;
        r_rightSkin.transform.DOLocalMove(position_R_Right, 0.4f);
        

        safeIndexCenter = (safeIndexRight + 1 == 6) ? 0 : (safeIndexRight + 1);
        
        c_centerSkin = skins[safeIndexCenter].gameObject;
        c_centerSkin.transform.DOLocalMove(position_C_Center, 0.4f);
    }

    public void MoveQueueLeft()
    {

        //Un dels errors es que esto es nulo, pq al r_right fa rightIndex +1, i d'aqui potser venen mes errors
      

        safeIndexRight = (safeIndexCenter - 1 == -1) ? 0 : (safeIndexCenter);
        r_rightSkin = skins[safeIndexRight].gameObject;
        r_rightSkin.transform.DOLocalMove(position_R_Right, 0.4f);

        safeIndexCenter = (safeIndexLeft - 1 == -1) ? 0 : (safeIndexLeft);
        c_centerSkin = skins[safeIndexCenter].gameObject;
        c_centerSkin.transform.DOLocalMove(position_C_Center, 0.4f);

        safeIndexLeft = (leftIndex - 1 == -1) ? 0 : (leftIndex);
        l_leftSkin = skins[safeIndexLeft].gameObject;
        l_leftSkin.transform.DOLocalMove(position_L_Left, 0.4f);



        leftIndex = centerIndex;
  
        leftSkin = skins[leftIndex].gameObject;
        leftSkin.transform.DOLocalMove(positionLeft,0.4f);
        leftSkin.transform.localScale /= 1.5f;

        centerIndex = rightIndex;

        centerSkin = skins[centerIndex].gameObject;
        centerSkin.transform.localScale *= 1.5f;
        centerSkin.transform.DOLocalMove(positionCenter, 0.4f);
        centerIndex = rightIndex;
        //skins[safeIndexLeft].gameObject.SetActive(false);
        FadeOut(skins[safeIndexLeft]);
        rightIndex = rightIndex + 1;
       
        if (rightIndex > 5)
        {
            rightIndex = 0;
        }

        rightSkin = skins[rightIndex].gameObject;
        rightSkin.transform.DOLocalMove(positionRight, 0.4f);
        FadeIn(skins[rightIndex]);
        //rightSkin.gameObject.SetActive(true);

    
    }

    private void FadeOut(SpriteRenderer sr)
    {
        sr.DOFade(0f, 0.3f).OnComplete(() => sr.gameObject.SetActive(false));
    }

    private void FadeIn(SpriteRenderer sr)
    {
        sr.gameObject.SetActive(true);
        //sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0f);
        sr.DOFade(1f, 0.3f);
    }
}
