using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public float coins;
    public float shield;
    public float speedup;

    public GameObject speedScreen;
    public GameObject shieldScreen;

    public GameObject speedSoldOut;
    public GameObject shieldSoldOut;

    public bool SpeedUpGround;
    public bool ShieldGround;

    //public int coins;
    public TMP_Text coinText;

    // Start is called before the first frame update
    void Start()
    {
        ShopData data = ShopSaveSystem.LoadShop();

        coins = data.coins;
        speedup = data.speedup;
        shield = data.shield;

        //coins = 0;
        //coins += 20;
        speedup = 0;
        shield = 0;

        ShopSaveSystem.SaveShop(this);

        //ShopSaveSystem.SaveShop(this);

        shieldSoldOut.SetActive(false);
        speedSoldOut.SetActive(false);
        //multiplierSoldOut.SetActive(false);

        shieldScreen.SetActive(false);
        speedScreen.SetActive(false);
        //multiplierScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Dont forget to ad a tag to the ground named speedupGround.
        if (other.gameObject.CompareTag("speedupGround"))
        {
            ShieldGround = false;
            SpeedUpGround = true;
            //CoinMultiplierGround = false;
        }
        if (other.gameObject.CompareTag("shieldGround"))
        {
            ShieldGround = true;
            SpeedUpGround = false;
            //CoinMultiplierGround = false;
        }
        if (other.gameObject.CompareTag("otherGround"))
        {
            shieldSoldOut.SetActive(false);
            speedSoldOut.SetActive(false);
            //multiplierSoldOut.SetActive(false);

            shieldScreen.SetActive(false);
            speedScreen.SetActive(false);
            //multiplierScreen.SetActive(false);

            ShieldGround = false;
            SpeedUpGround = false;
            //CoinMultiplierGround = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ShopData data = ShopSaveSystem.LoadShop();
        shield = data.shield;

        if (ShieldGround == true)
        {
            if (shield >= 1)
            {
                shieldSoldOut.SetActive(true);
                speedSoldOut.SetActive(false);
                //multiplierSoldOut.SetActive(false);

                shieldScreen.SetActive(false);
                speedScreen.SetActive(false);
                //multiplierScreen.SetActive(false);
            }
            if (shield <= 0)
            {
                shieldScreen.SetActive(true);
                speedScreen.SetActive(false);
                //multiplierScreen.SetActive(false);

                if (Input.GetKeyUp(KeyCode.B))
                {
                    print("you pressed the Buy key");
                    if (coins >= 3)
                    {
                        coins -= 3;
                        shield += 1;
                        ShopSaveSystem.SaveShop(this);
                    }
                    if (coins <= 2)
                    {
                        print("You dont have enough coins");
                    }
                }
                shieldSoldOut.SetActive(false);
                speedSoldOut.SetActive(false);
                //multiplierSoldOut.SetActive(false);
            }
        }
        if(SpeedUpGround == true)
        {
            if (speedup >= 2)
            {
                shieldSoldOut.SetActive(false);
                speedSoldOut.SetActive(true);
                //multiplierSoldOut.SetActive(false);

                shieldScreen.SetActive(false);
                speedScreen.SetActive(false);
                //multiplierScreen.SetActive(false);
            }
            if (speedup <= 1)
            {
                speedScreen.SetActive(true);
                shieldScreen.SetActive(false);
                //multiplierScreen.SetActive(false);

                if (Input.GetKeyUp(KeyCode.B))
                {
                    print("you pressed the Buy key");
                    if (coins >= 5)
                    {
                        coins -= 5;
                        speedup += 1;
                        ShopSaveSystem.SaveShop(this);
                    }
                    if (coins <= 4)
                    {
                        print("You dont have enough coins");
                    }

                }
                shieldSoldOut.SetActive(false);
                speedSoldOut.SetActive(false);
                //multiplierSoldOut.SetActive(false);
            }
        }
        coinText.text = "Coin: " + coins;
        ShopSaveSystem.SaveShop(this);
    } 
}
