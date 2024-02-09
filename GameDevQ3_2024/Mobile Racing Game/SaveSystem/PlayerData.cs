using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float HighScore;

    //These are values for the master game settings.
    public string UserName;
    public string CurrentCar;
    public float MasterVolume;

    public PlayerData (PointManager PlayerDataScore)
    {
        HighScore = PlayerDataScore.HighScore;

        UserName = PlayerDataScore.UserName;
        CurrentCar = PlayerDataScore.CurrentCar;
        MasterVolume = PlayerDataScore.MasterVolume;
    }
}
