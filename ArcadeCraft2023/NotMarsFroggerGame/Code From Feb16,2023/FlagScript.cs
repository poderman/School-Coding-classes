using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    public GameObject Frog;
    public GameObject RespawnPoint;

    public PointManager PointManager;

    public GameObject MainCamera1;
    public GameObject MainCamera2;

    public AudioSource HitFlagSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PointManager.FlagCollect += 1;
            HitFlagSound.Play();

            Frog.transform.position = RespawnPoint.transform.position;
            MainCamera1.SetActive(true);
            MainCamera2.SetActive(false);
            Destroy(gameObject);
        }
    }
}
