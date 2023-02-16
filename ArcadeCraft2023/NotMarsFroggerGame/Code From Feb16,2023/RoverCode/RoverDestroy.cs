using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverDestroy : MonoBehaviour
{
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
        //Dont forget to a a tag to the player named Player.
        if (other.gameObject.CompareTag("RoverEnd"))
        {
            Destroy(gameObject);
        }
    }
}
