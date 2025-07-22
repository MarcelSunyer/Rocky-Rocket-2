using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LightGalaxy : MonoBehaviour
{
    private SpriteRenderer galaxy;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        galaxy = GetComponentInChildren<SpriteRenderer>();

        if (button == null )
        {
            print("Button Null");
        }

        if ( galaxy == null )
        {
            print("Galaxy null");
        }
    }
    private void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == button)
        {
            Debug.Log(this.button.name + " was selected");
        }
    }
    public void OnSelect(BaseEventData eventData)
    {
        if (eventData.selectedObject == button)
        {
            Debug.Log(this.button.name + " was selected");
        }
    }
}
