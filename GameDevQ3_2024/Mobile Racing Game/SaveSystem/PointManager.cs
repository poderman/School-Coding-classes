using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public float score;

    public float HighScore;

    //These are the values for the master game settings.
    public string UserName;
    public string CurrentCar;
    public float MasterVolume;

    void Awake()
    {
        PlayerData data = SaveSystem.LoadScore();
        HighScore = data.HighScore;

        UserName = data.UserName;
        CurrentCar = data.CurrentCar;
        MasterVolume = data.MasterVolume;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveHScore()
    {
        if (score > HighScore)
        {
            HighScore = score;
        }
        else
        {
            PlayerData data = SaveSystem.LoadScore();
            HighScore = data.HighScore;
        }

        SaveSystem.SaveScore(this);
    }

    public void LoadHScore()
    {
        PlayerData data = SaveSystem.LoadScore();
        HighScore = data.HighScore;

        UserName = data.UserName;
        CurrentCar = data.CurrentCar;
        MasterVolume = data.MasterVolume;
    }

}
