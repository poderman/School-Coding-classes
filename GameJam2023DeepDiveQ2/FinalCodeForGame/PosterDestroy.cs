using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterDestroy : MonoBehaviour
{
    public GameObject Poster;

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
        //Dont forget to ad a tag to the ground named speedupGround.
        if (other.gameObject.CompareTag("Player"))
        {
            Poster.SetActive(false);
        }
    }
}
