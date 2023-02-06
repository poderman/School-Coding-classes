using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopCode : MonoBehaviour
{
    public PlayerHealth PlayerHealth;

    public GameObject Shop;
    public GameObject ExitShop;

    public int SpeedUp;
    public int Shield;
    public int Bomb;

    public int SpeedUpCost;
    public int ShieldCost;
    public int BombCost;

    public TMP_Text SpeedUpText;
    public TMP_Text ShieldText;
    public TMP_Text BombText;

    // Start is called before the first frame update
    void Start()
    {
        SpeedUp = 0;
        Shield = 0;
        Bomb = 0;

        SpeedUpCost = 3;
        ShieldCost = 3;
        BombCost = 3;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedUpText.text = "Coins: " + SpeedUpCost.ToString("N0");
        ShieldText.text = "Coins: " + ShieldCost.ToString("N0");
        BombText.text = "Coins: " + BombCost.ToString("N0");
    }

    public void ShopButton()
    {
        ExitShop.SetActive(true);
        Shop.SetActive(false);
    }

    public void ExitShopButton()
    {
        ExitShop.SetActive(false);
        Shop.SetActive(true);
    }

    
    public void SpeeedUpButton()
    {
        if (PlayerHealth.coins >= SpeedUpCost)
        {
            PlayerHealth.coins -= SpeedUpCost;
            SpeedUp += 1;
            SpeedUpCost += 2;
        }
    }

    public void ShieldButton()
    {
        if (PlayerHealth.coins >= ShieldCost)
        {
            PlayerHealth.coins -= ShieldCost;
            Shield += 1;
            ShieldCost += 1;
        }
    }

    public void BombButton()
    {
        if (PlayerHealth.coins >= BombCost)
        {
            PlayerHealth.coins -= BombCost;
            Bomb += 1;
            BombCost += 1;
        }
    }
}
