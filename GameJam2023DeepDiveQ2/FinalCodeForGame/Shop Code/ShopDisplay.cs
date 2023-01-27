using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopDisplay : MonoBehaviour
{
    public GameObject speedScreen;
    public GameObject shieldScreen;

    public GameObject speedSoldOut;
    public GameObject shieldSoldOut;

    public bool SpeedUpGround;
    public bool ShieldGround;

    public ShopManager ShopManager;

    // Start is called before the first frame update
    void Start()
    {
        ShopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();

        shieldSoldOut.SetActive(false);
        speedSoldOut.SetActive(false);

        shieldScreen.SetActive(false);
        speedScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Shop1")
        {
            if (ShieldGround == true)
            {
                if (ShopManager.shield >= 1)
                {
                    shieldSoldOut.SetActive(true);
                    speedSoldOut.SetActive(false);

                    shieldScreen.SetActive(false);
                    speedScreen.SetActive(false);
                }
               if (ShopManager.shield <= 0)
                {
                    shieldScreen.SetActive(true);
                    speedScreen.SetActive(false);

                    if (Input.GetKeyUp(KeyCode.B))
                    {
                        print("you pressed the Buy key");
                        if (ShopManager.coins >= 4)
                        {
                            ShopManager.coins -= 4;
                            ShopManager.shield += 1;
                        }
                        if (ShopManager.coins <= 3)
                        {
                            print("You dont have enough coins");
                        }
                    }
                    shieldSoldOut.SetActive(false);
                    speedSoldOut.SetActive(false);
                }
            }
            if(SpeedUpGround == true)
            {
                if (ShopManager.speedup >= 2)
                {
                    shieldSoldOut.SetActive(false);
                    speedSoldOut.SetActive(true);

                    shieldScreen.SetActive(false);
                    speedScreen.SetActive(false);
                }
                if (ShopManager.speedup <= 1)
                {
                    speedScreen.SetActive(true);
                    shieldScreen.SetActive(false);

                    if (Input.GetKeyUp(KeyCode.B))
                    {
                        print("you pressed the Buy key");
                        if (ShopManager.coins >= 3)
                        {
                            ShopManager.coins -= 3;
                            ShopManager.speedup += 1;
                        }
                        if (ShopManager.coins <= 2)
                        {
                            print("You dont have enough coins");
                        }

                    }
                    shieldSoldOut.SetActive(false);
                    speedSoldOut.SetActive(false);
                }
            }
        }

        if (SceneManager.GetActiveScene().name == "Shop2")
        {
            if (ShieldGround == true)
            {
                if (ShopManager.shield >= 1)
                {
                    shieldSoldOut.SetActive(true);
                    speedSoldOut.SetActive(false);

                    shieldScreen.SetActive(false);
                    speedScreen.SetActive(false);
                }
               if (ShopManager.shield <= 0)
                {
                    shieldScreen.SetActive(true);
                    speedScreen.SetActive(false);

                    if (Input.GetKeyUp(KeyCode.B))
                    {
                        print("you pressed the Buy key");
                        if (ShopManager.coins >= 4)
                        {
                            ShopManager.coins -= 4;
                            ShopManager.shield += 1;
                        }
                        if (ShopManager.coins <= 3)
                        {
                            print("You dont have enough coins");
                        }
                    }
                    shieldSoldOut.SetActive(false);
                    speedSoldOut.SetActive(false);
                }
            }
            if(SpeedUpGround == true)
            {
                if (ShopManager.speedup >= 2)
                {
                    shieldSoldOut.SetActive(false);
                    speedSoldOut.SetActive(true);

                    shieldScreen.SetActive(false);
                    speedScreen.SetActive(false);
                }
                if (ShopManager.speedup <= 1)
                {
                    speedScreen.SetActive(true);
                    shieldScreen.SetActive(false);

                    if (Input.GetKeyUp(KeyCode.B))
                    {
                        print("you pressed the Buy key");
                        if (ShopManager.coins >= 5)
                        {
                            ShopManager.coins -= 5;
                            ShopManager.speedup += 1;
                        }
                        if (ShopManager.coins <= 4)
                        {
                            print("You dont have enough coins");
                        }

                    }
                    shieldSoldOut.SetActive(false);
                    speedSoldOut.SetActive(false);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Dont forget to ad a tag to the ground named speedupGround.
        if (other.gameObject.CompareTag("speedupGround"))
        {
            ShieldGround = false;
            SpeedUpGround = true;
        }
        if (other.gameObject.CompareTag("shieldGround"))
        {
            ShieldGround = true;
            SpeedUpGround = false;
        }
        if (other.gameObject.CompareTag("otherGround"))
        {
            shieldSoldOut.SetActive(false);
            speedSoldOut.SetActive(false);

            shieldScreen.SetActive(false);
            speedScreen.SetActive(false);

            ShieldGround = false;
            SpeedUpGround = false;
        }
    }
}
