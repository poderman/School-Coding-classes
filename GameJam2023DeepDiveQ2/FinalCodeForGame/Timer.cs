using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    //public TMP_Text time;
    //public Leaderboard leaderboard;
    public int TimerScore;
    //public GameObject player;

    //public string ChooseAScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( TimerScore == 0)
        {
            timer += Time.deltaTime;
        }

        if (SceneManager.GetActiveScene().name == "Shop1")
        {
            TimerScore = 1;
        }
        if (SceneManager.GetActiveScene().name == "Shop2")
        {
            TimerScore = 1;
        }
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            TimerScore = 0;
        }
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            TimerScore = 0;
        }
        if (SceneManager.GetActiveScene().name == "Level3")
        {
            TimerScore = 0;
        }
        if (SceneManager.GetActiveScene().name == "Win")
        {
            TimerScore = 1;
        }
    }
/*
       private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("look");
        //Dont forget to a a tag to the player named Player.
        if (other.gameObject.CompareTag("Player"))
        {

            score = false;
            SaveSystem.SaveTime(this);
            if (SceneManager.GetActiveScene().name == "Level3")
            {
                Debug.Log("Level3");
                StartCoroutine(SubmitScore());
                Destroy(GameObject.Find("Canvas Dont Destroy"));
                Destroy(GameObject.Find("ShopManager"));
                timer = 0;
                SceneManager.LoadScene(ChooseAScene);
            }
            Debug.Log("test");
            SceneManager.LoadScene(ChooseAScene);
        }
    }

    IEnumerator SubmitScore()
    {
        yield return leaderboard.SubmitScoreRoutine((int)timer);
        yield return new WaitForSeconds(0.2f);

    }*/
}
