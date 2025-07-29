using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

    public int galaxy;
    public int level;
    public bool firstGame;

    public SpriteRenderer spriteRenderer;
    public PlayerData (ShipController ship)
    {
        galaxy = ship.galaxy;
        level = ship.level;
        firstGame = ship.firstGame;
        spriteRenderer = ship.ship;

    }
}
 