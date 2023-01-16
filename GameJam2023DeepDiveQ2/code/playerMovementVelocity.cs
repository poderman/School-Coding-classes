using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovmentVelocity : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        playerRb.velocity = Vector2.right * horizontal * speed;
    }

}
