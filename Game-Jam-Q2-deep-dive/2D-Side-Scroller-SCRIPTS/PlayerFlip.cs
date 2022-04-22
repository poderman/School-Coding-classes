using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private Vector3 playerScale;
    public string flipDirection = "Right";


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Flip();
        }
        if (Input.GetKey(KeyCode.D))
        {
            Flip();
        }
    }



    void Flip()
    {
        if (playerMovement.playerDirection == "Right")
        {
            if(flipDirection == "Left")
            {
                playerScale = transform.localScale;
                playerScale.x *= -1;
                transform.localScale = playerScale;
                flipDirection = "Right";
            }
            
        }

        if (playerMovement.playerDirection == "Left")
        {
            if (flipDirection == "Right")
            {
                playerScale = transform.localScale;
                playerScale.x *= -1;
                transform.localScale = playerScale;
                flipDirection = "Left";
            }
        }
    }
}
