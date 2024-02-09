using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamePanel : MonoBehaviour
{
    public GameObject pausePanel;

    public PlayerMovement PlayerMovement;
    public PlayerHealth PlayerHealth;
    public TMP_Text playerPointsText;

    public float playerPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPoints = PlayerHealth.playerPoints;
        playerPointsText.text = "Points: " + playerPoints.ToString("N0");
    }

    public void PauseMenu()
    {
        PlayerMovement.enabled = false;
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
