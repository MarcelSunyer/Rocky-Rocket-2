using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LightGalaxy : MonoBehaviour
{
    public SpriteRenderer galaxy;

    private Button button;

    public Color firstColor;

    public Color secondColor;

    private void Start()
    {
        button = GetComponent<Button>();

        button.image.color = secondColor;
    }
    private void Update()
    {

        if (EventSystem.current.currentSelectedGameObject == button.gameObject)
        {
            button.image.color = firstColor;

        }
        else
        {
            button.image.color = secondColor;
        }
    }
}
