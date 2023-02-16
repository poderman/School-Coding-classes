using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
    public int playerHealth;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        playerHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth == 0)
        {
            //GameOver

            Time.timeScale = 0;

            GameOver.SetActive(true);

            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(false);
        }
        else if (playerHealth == 3)
        {
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
        }
        else if (playerHealth == 2)
        {
            Heart3.SetActive(false);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
        }
        else if (playerHealth == 1)
        {
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(true);
        }
    }
}
