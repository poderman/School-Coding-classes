using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public TMP_Text coinText;
    public ShopManager ShopManager;

    // Start is called before the first frame update
    void Start()
    {
        ShopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coin: " + ShopManager.coins;
    }
}
