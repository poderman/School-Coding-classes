using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float timer;

    public PlayerData (Timer PlayerDataTimer)
    {
        timer = PlayerDataTimer.timer;
    }
}


