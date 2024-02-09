using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacerMovement : MonoBehaviour
{
    public float speed = 5f;  // Adjust the speed as needed

    private float GoLeft;
    private float timer;

    private Vector2 movement;

    public bool moveAtAngle = true;

    void Start()
    {
        GoLeft = Random.Range(0f, 1f);
        timer = 3;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (moveAtAngle == true)
        {
            if (GoLeft >= 0.5)
            {
                // Calculate the movement direction
                movement = new Vector2(-0.6f, -1f).normalized;
            }
            else
            {
                // Calculate the movement direction
                movement = new Vector2(0.6f, -1f).normalized;
            }
        }
        else
        {
            movement = new Vector2(0f, -1f).normalized;
        }

        // Move the object
        transform.Translate(movement * speed * Time.deltaTime);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("OffRoad") && timer > 0.5f)
        {
            timer = 0;

            if (GoLeft == 1)
            {
                GoLeft = 0;
            }
            else
            {
                GoLeft = 1;
            }
        }
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
    
    
    
    
    
    /*
    private Vector2 startPosition;
    public float moveSpeed = 5f;
    public float loopDistance = 14f;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Calculates where the screen should be
        float newPosition = Mathf.Repeat(Time.time * moveSpeed, loopDistance);

        //Moves the screen in place
        transform.position = startPosition + Vector2.down * newPosition;
    }*/
}
