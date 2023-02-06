using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5;

    public Animator animator;

    private Vector2 movement;
    public Rigidbody2D rb;

    public ShopCode ShopCode;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);

        if(Mathf.Abs(movement.x) >= 0.2f || Mathf.Abs(movement.y) >= 0.2f )
            animator.SetBool("isWalking", true);
        if (Mathf.Abs(movement.x) <= 0.2f && Mathf.Abs(movement.y) <= 0.2f)
            animator.SetBool("isWalking", false);

        if (ShopCode.SpeedUp == 0)
        {
            moveSpeed = 5;
        }
        if (ShopCode.SpeedUp == 1)
        {
            moveSpeed = 7;
        }
        if (ShopCode.SpeedUp == 2)
        {
            moveSpeed = 9;
        }
        if (ShopCode.SpeedUp == 3)
        {
            moveSpeed = 11;
        }
        if (ShopCode.SpeedUp == 4)
        {
            moveSpeed = 13;
        }
    }

    void FixedUpdate()
    {
        Debug.Log(movement);
        rb.velocity = movement * moveSpeed;
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}