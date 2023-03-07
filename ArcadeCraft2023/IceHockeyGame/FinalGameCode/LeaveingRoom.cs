using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LeaveingRoom : MonoBehaviour
{
    public float timer;
    public int OnTimer;

    public TMP_Text playerDisconnected;

    // Start is called before the first frame update
    void Start()
    {
        timer = 10;
        OnTimer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        playerDisconnected.text = "Player Disconnected Leaving Game in " + timer.ToString("N0");

        if(OnTimer == 1);
        {
            timer -= Time.deltaTime;
        }
        if(timer <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
