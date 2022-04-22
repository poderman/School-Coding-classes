using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovment : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movment;

    // Update is called once per frame
    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
    }

}
