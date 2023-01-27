using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGame : MonoBehaviour
{
    public Leaderboard leaderboard;
    public Timer Timer;
    public string ChooseAScene;

    // Start is called before the first frame update
    void Start()
    {
        Timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        StartCoroutine(SubmitScore());
        Destroy(GameObject.Find("ShopManager"));
        Destroy(GameObject.Find("Timer"));
        SceneManager.LoadScene(ChooseAScene);
    }

    IEnumerator SubmitScore()
    {
        yield return leaderboard.SubmitScoreRoutine((int)Timer.timer);
        yield return new WaitForSeconds(0.5f);

    }
}
