using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private bool isPaused;
    public Leaderboard leaderboard;

    public float timer;
    public float TimerScore;
    public TMP_Text time;

    public GameObject WinScreen;

    public PlayerHealth PlayerHealth;
    public string ChooseAScene;

    // Start is called before the first frame update
    void Start()
    {
        timer = 30;
        TimerScore = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + timer.ToString("N0");

        if( TimerScore == 1)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            TimerScore = 0;
            Time.timeScale = 0;
            isPaused = true;
            WinScreen.SetActive(true);
        }
    }

    public void SubmitName()
    {
        TimerScore = 0;
        StartCoroutine(SubmitScore());
        SceneManager.LoadScene(ChooseAScene);
    }

    IEnumerator SubmitScore()
    {
        yield return leaderboard.SubmitScoreRoutine((int)PlayerHealth.coins);
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1;
        isPaused = false;
    }
}
