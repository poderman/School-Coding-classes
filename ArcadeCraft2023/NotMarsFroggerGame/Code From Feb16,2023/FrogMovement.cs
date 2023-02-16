using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector2.right);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveRight());
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector2.left);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveLeft());
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            rb.MovePosition(rb.position + Vector2.up);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveUp());
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rb.MovePosition(rb.position + Vector2.down);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveDown());
            }
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveRight());
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveLeft());
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveUp());
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
            if (transform.parent != null && transform.parent.CompareTag("Drone"))
            {
                transform.parent = null;
                StartCoroutine(MoveDown());
            }
        }
    }

    IEnumerator MoveUp()
    {
        yield return new WaitForSeconds(0.01f);
        rb.MovePosition(rb.position + Vector2.up);
    }
    IEnumerator MoveDown()
    {
        yield return new WaitForSeconds(0.01f);
        rb.MovePosition(rb.position + Vector2.down);
    }
    IEnumerator MoveLeft()
    {
        yield return new WaitForSeconds(0.01f);
        rb.MovePosition(rb.position + Vector2.left);
    }
    IEnumerator MoveRight()
    {
        yield return new WaitForSeconds(0.01f);
        rb.MovePosition(rb.position + Vector2.right);
    }
}
