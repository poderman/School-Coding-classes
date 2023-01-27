using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D playerRb;

    public int speed;

    //public float speedup;

    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;

    public LayerMask groundLayer;
    private bool isGrounded;
    public Transform feetPosition;
    public float groundCheckCircle;

    public float jumpTime = 0.35f;
    public float jumpTimeCounter;
    public bool isJumping;

    public ShopManager ShopManager;

    // Start is called before the first frame update
    void Start()
    {
        ShopManager = GameObject.Find("ShopManager").GetComponent<ShopManager>();

        //speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (ShopManager.speedup == 0)
        {
            speed = 4;
        }
        if (ShopManager.speedup == 1)
        {
            speed = 6;
        }
        if (ShopManager.speedup == 2)
        {
            speed = 8;
        }

        input = Input.GetAxisRaw("Horizontal");
        if(input < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (input > 0)
        {
            spriteRenderer.flipX = false;
        }

        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, groundLayer);

        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            playerRb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                playerRb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }

            else
            {
                isJumping = false;
            }
           
        }

        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    private void FixedUpdate()
    {
        playerRb.velocity = new Vector2(input * speed, playerRb.velocity.y);
    }
}
