using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitFall : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject Player;

    public PlayerHealth PlayerHealth;

    public Animator PlayerAnim;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag== "Pit")
        {
            Debug.Log("Pit Fall" + collision.gameObject.name);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<PlayerMovement>().enabled = false;
            PlayerHealth.currentHealth -= 1;
            StartCoroutine(Falling());
        } 
    }

    IEnumerator Falling()
    {
        PlayerAnim.Play("PlayerFall");
        yield return new WaitForSeconds(1.5f);
        transform.position = respawnPoint.transform.position;
        GetComponent<PlayerMovement>().enabled = true;
    }
}
