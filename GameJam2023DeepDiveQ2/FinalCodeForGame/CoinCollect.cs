using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public ShopManager ShopManager;

    void Start()
    {
        ShopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ShopManager.coins += 1;
            Destroy(gameObject);
        }
    }
}
