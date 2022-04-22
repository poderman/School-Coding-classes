using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float jumpForce = 4;
    public bool isJumping;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isJumping == false)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
                isJumping = true;

            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
