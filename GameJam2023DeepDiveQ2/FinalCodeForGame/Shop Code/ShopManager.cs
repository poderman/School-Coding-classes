using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using TMPro;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public int shield;
    public int speedup;

    //public int coins;
    //public TMP_Text coinText;

    //public GameObject UniShield;

    // Start is called before the first frame update
    void Start()
    {
        //speedup = 2;
        //StartCoroutine(FindCoins());

        //UniShield = GameObject.Find("UniShield");

    }

    // Update is called once per frame
    void Update()
    {
        //coinText.text = "Coin: " + coins;
        /*
        if (shield == 1)
        {
            UniShield.SetActive(true);
        }
        if (shield == 0)
        {
            UniShield.SetActive(false);
        }*/
    }

/*
    IEnumerator FindCoins()
    {
        yield return new WaitForSeconds(1);
        GameObject coin = GameObject.Find("Coin");
        coinText = coin.GetComponent<TMP_Text>();
    }*/
}
