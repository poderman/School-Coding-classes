using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopData
{
    public float coins;
    public float speedup;
    public float shield;
    //public float multiplier;

    public ShopData (ShopManager ShopManagerData)
    {
        coins = ShopManagerData.coins;
        speedup = ShopManagerData.speedup;
        shield = ShopManagerData.shield;
    }

    public ShopData (RespawnScript RespawnScriptData)
    {
        shield = RespawnScriptData.shield;
    }

    public ShopData (PlayerMove PlayerMoveData)
    {
        speedup = PlayerMoveData.speedup;
    }
}
