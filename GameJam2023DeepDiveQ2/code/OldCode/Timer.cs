using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    public TMP_Text time;
    public Leaderboard leaderboard;
    bool score;
    public GameObject player;

    public string ChooseAScene;

    // Start is called before the first frame update
    void Start()
    {
        score = true;
        PlayerData data = SaveSystem.LoadTime();

        timer = data.timer;

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            Debug.Log("Level1");
            timer = 0;
        };

        //timer = 0;
        SaveSystem.SaveTime(this);
    }

    // Update is called once per frame
    void Update()
    {
        if(score == true)
        {
            time.text = "Time: " + timer.ToString("N0");
            timer += Time.deltaTime;
        }
       
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Dont forget to a a tag to the player named Player.
        if (other.gameObject.CompareTag("Player"))
        {
            score = false;
            SaveSystem.SaveTime(this);
            if (SceneManager.GetActiveScene().name == "Level3")
            {
                Debug.Log("Level3");
                StartCoroutine(SubmitScore());
                timer = 0;
                SceneManager.LoadScene(ChooseAScene);
            };
			SceneManager.LoadScene(ChooseAScene);
        }
        //Dont forget to a a tag to the player named PlayerLevel2.
        if (other.gameObject.CompareTag("Finish"))
        {
            score = false;
            //StartCoroutine(SubmitScore());
            //timer = 0;
            //SaveSystem.SaveTime(this);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
            //submitScreen.SetActive(true);
            ///timerText.SetActive(false);
        }
    }

    IEnumerator SubmitScore()
    {
        yield return leaderboard.SubmitScoreRoutine((int)timer);
        yield return new WaitForSeconds(0.2f);

    }
}
