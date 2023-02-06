using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinTakeDamage : MonoBehaviour
{
    public PlayerHealth PlayerHealth;

    public PlayerMovement PlayerMovement;//This is what calls the PlayerMovement script so that this script can change the currentHealth varriable

    public Rigidbody2D rb;

    public float strength = 160;//this is the push back strength

    // Start is called before the first frame update
    void Start()
    {
        //PlayerHealth = GameObject.Find("PlayerHealth").GetComponent<PlayerHealth>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Goblin"))//Dont forget to label GoblinSword GoblinSword
        {
            Vector2 direction = (transform.position - collision.transform.position).normalized;
            Debug.Log(direction);//This Debugs the direction of the player when you hit the Ghost object
            rb.AddForce(direction * strength);
            PlayerMovement.enabled = false;//This turns off the player movement script
            StartCoroutine(Timer());//This start the IEnumerator Timer
            PlayerHealth.currentHealth -= 1;//this makes the player health go down
        }
    }
    //This is what makes the player script trun on after blank seconds
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(.5f);//this is how many seconds you want the PlayerMovement script to stay off
        PlayerMovement.enabled = true;//This turns on the PlayerMovement script
    }
}
