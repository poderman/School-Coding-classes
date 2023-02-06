using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;//This is the max health for the player

    public int coins;
    public int minCoins = 0;

    public GameObject player;
    public GameObject respawnPoint;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public TMP_Text coinText;

    public ShopCode ShopCode;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;//This makes the currentHealth = the maxHealth
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coin: " + coins;

        if (currentHealth == 0)
        {
            coins = minCoins;
            currentHealth = maxHealth;
            player.transform.position = respawnPoint.transform.position;
        }

        if (currentHealth == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }
        if (currentHealth == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);
        }
        if (currentHealth == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }

        if (ShopCode.Shield == 1)
        {
            currentHealth += 1;
            ShopCode.Shield -= 1;
        }
    }
}
