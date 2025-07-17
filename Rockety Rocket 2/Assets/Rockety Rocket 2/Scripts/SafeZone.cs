using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    private SpriteRenderer sprite;
    public UnityEngine.Color idle;
    public UnityEngine.Color idleColor;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        print(sprite.color);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship")) {
            if (sprite.color == idle)
            {
                sprite.color = idleColor;
            }

        }
    }
}
