using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuPointManager : MonoBehaviour
{
    public float HighScore;

    public TMP_Text HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerData data = SaveSystem.LoadScore();

        HighScore = data.HighScore;
    }

    // Update is called once per frame
    void Update()
    {
        HighScoreText.text = "HighScore:" + HighScore.ToString("N0");
    }
}
