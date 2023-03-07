using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float HighScore;

    public GameData (PointManager PlayerDataScore)
    {
        HighScore = PlayerDataScore.HighScore;
    }
}