using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    public TimeManager TimeManager;
    public GameObject GameOver;

    public float score;
    public float TimerScore;

    public float HighScore;
    public string WinScreen;

    public float FlagCollect;

    //public Leaderboard leaderboard;

    public TMP_Text HighScoreText;
    public TMP_Text HighScoreWinText;
    public TMP_Text YourScoreWinText;

    public GameObject WinScreenOn;
    public GameObject NewHighScore;

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
        //StartCoroutine(SubmitScore());
        if (TimeManager.currentTime <= 0)
        {
            //GameOver

            Time.timeScale = 0;
/*
            TimerScore = TimeManager.currentTime;
            TimerScore *= 20;
            score += TimerScore;

            GameOver.SetActive(true);*/
        }
        if (score >= HighScore)
        {
            HighScore = score;
            SaveSystem.SaveScore(this);
        }
        if (FlagCollect == 3)
        {
            //SceneManager.LoadScene(WinScreen);

            Time.timeScale = 0;

            TimerScore = TimeManager.currentTime;
            TimerScore *= 20;
            score += TimerScore;

            WinScreenOn.SetActive(true);
            YourScoreWinText.text = "YourScore:" + score.ToString("N0");
            HighScoreWinText.text = "HighScore:" + HighScore.ToString("N0");

            FlagCollect = 0;

            if (score >= HighScore)
            {
                HighScore = score;
                NewHighScore.SetActive(true);
                HighScoreWinText.text = "HighScore:" + HighScore.ToString("N0");
            }
        }

    }

    /*IEnumerator SubmitScore()
    {
        yield return leaderboard.SubmitScoreRoutine((int)HighScore);
        yield return new WaitForSeconds(0.5f);

    }*/

    public void SaveHScore()
    {
        SaveSystem.SaveScore(this);
        //StartCoroutine(SubmitScore());
    }

    public void LoadHScore()
    {
        PlayerData data = SaveSystem.LoadScore();
        HighScore = data.HighScore;
    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //SceneManager.LoadScene(WinScreen);

            Time.timeScale = 0;

            TimerScore = TimeManager.currentTime;
            TimerScore *= 20;
            score += TimerScore;

            WinScreenOn.SetActive(true);
            YourScoreWinText.text = "YourScore:" + score.ToString("N0");
            HighScoreWinText.text = "HighScore:" + HighScore.ToString("N0");
            if (score >= HighScore)
            {
                HighScore = score;
                NewHighScore.SetActive(true);
                HighScoreWinText.text = "HighScore:" + HighScore.ToString("N0");
            }
        }
    }*/

}
