using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject Frog;
    public GameObject respawnPoint;

    public PlayerHeath PlayerHeath;

    public GameObject MainCamera1;
    public GameObject MainCamera2;

    public GameObject player;

    public AudioSource Death;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent != null && transform.parent.CompareTag("Drone"))
        {
            player.transform.localPosition = new Vector3(0f, 0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Dont forget to a a tag to the player named Player.
        if (other.gameObject.CompareTag("Rover"))
        {
            PlayerHeath.playerHealth -= 1;
            Death.Play();
            
            Frog.transform.position = respawnPoint.transform.position;
            MainCamera1.SetActive(true);
            MainCamera2.SetActive(false);
        }
        /*if (other.gameObject.CompareTag("Pit"))
        {
            if (transform.parent == null || !transform.parent.CompareTag("Drone"))
            {
                PlayerHeath.playerHealth -= 1;
                Frog.transform.position = respawnPoint.transform.position;
                MainCamera1.SetActive(true);
                MainCamera2.SetActive(false);
            }
        }*/
    }
    /*private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pit"))
        {
            //StartCoroutine(HitPit());
            if (transform.parent == null || !transform.parent.CompareTag("Drone"))
            {
                PlayerHeath.playerHealth -= 1;
                Frog.transform.position = respawnPoint.transform.position;
                MainCamera1.SetActive(true);
                MainCamera2.SetActive(false);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Drone"))
        {
            StartCoroutine(HitPit());
            if (transform.parent == null || !transform.parent.CompareTag("Drone"))
            {
                PlayerHeath.playerHealth -= 1;
                Frog.transform.position = respawnPoint.transform.position;
                MainCamera1.SetActive(true);
                MainCamera2.SetActive(false);
            }
        }
    }
    IEnumerator HitPit()
    {
        yield return new WaitForSeconds(0.5f);
        /*if (transform.parent == null || !transform.parent.CompareTag("Drone"))
        {
            PlayerHeath.playerHealth -= 1;
            Frog.transform.position = respawnPoint.transform.position;
            MainCamera1.SetActive(true);
            MainCamera2.SetActive(false);
        }
        if (transform.parent == null || !transform.parent.CompareTag("Drone"))
            {
                PlayerHeath.playerHealth -= 1;
                Frog.transform.position = respawnPoint.transform.position;
                MainCamera1.SetActive(true);
                MainCamera2.SetActive(false);
            }
    }*/
}