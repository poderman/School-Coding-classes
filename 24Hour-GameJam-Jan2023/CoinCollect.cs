using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public PlayerHealth PlayerHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Dont forget to a a tag to the player named Player.
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.coins += 1;
            Destroy(gameObject);
        }
    }
}
