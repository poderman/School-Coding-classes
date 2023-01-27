using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject player;
    public GameObject respawnPoint;

    public ShopManager ShopManager;

    // Start is called before the first frame update
    void Start()
    {
        ShopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Dont forget to a a tag to the player named Player.
        if (other.gameObject.CompareTag("Player"))
        {
            if (ShopManager.shield == 0)
            {
                player.transform.position = respawnPoint.transform.position;
            }
            if (ShopManager.shield == 1)
            {
                ShopManager.shield = 0;
                Destroy(gameObject);
            }
        }
    }
}
