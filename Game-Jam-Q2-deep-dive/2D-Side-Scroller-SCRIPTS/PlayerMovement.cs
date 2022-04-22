using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 5;
    public Rigidbody2D playerRb;

    public string playerDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            playerRb.transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
            playerDirection = "Right";
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerRb.transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
            playerDirection = "Left";
        }

    }
}