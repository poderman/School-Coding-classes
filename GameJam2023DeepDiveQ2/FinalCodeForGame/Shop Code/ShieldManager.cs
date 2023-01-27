using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShieldManager : MonoBehaviour
{
    public ShopManager ShopManager;
    public GameObject UniShield;

    // Start is called before the first frame update
    void Start()
    {
        ShopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShopManager.shield == 1)
        {
            UniShield.SetActive(true);
        }
        if (ShopManager.shield == 0)
        {
            UniShield.SetActive(false);
        }
    }
}
