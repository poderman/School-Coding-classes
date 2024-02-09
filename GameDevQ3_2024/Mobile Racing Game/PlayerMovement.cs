using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;

    public Vector2 currentPosition;

    private Vector3 touchOffset;
    private bool isTouching = false;

    void Start()
    {

    }

    void Update()
    {
        // Check if there is at least one touch detected
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // On touch begin, calculate the offset from the GameObject's position to the touch position
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0; // Since it's a 2D game, ignore the z-component
                touchOffset = transform.position - touchPosition;
                isTouching = true;
            }
/*
            currentPosition = transform.position;
            if (currentPosition.x < -1.3f)
            {
                currentPosition.x = -1.28f;
            }
            else if (currentPosition.x > 1.4)
            {
                currentPosition.x = 1.38f;
            }

            transform.position = currentPosition;
            
            if (currentPosition.x > -1.3f && currentPosition.x < 1.4f)
            {
                // On moving the touch, update the GameObject's position with the offset
                if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && isTouching)
                {
                    Vector3 newPosition = Camera.main.ScreenToWorldPoint(touch.position) + touchOffset;
                    newPosition.z = 0; // Keep the GameObject in the correct plane
                    transform.position = newPosition;
                }
            }

            // On touch end, stop following
            if (touch.phase == TouchPhase.Ended)
            {
                isTouching = false;
            }
*/
            if ((touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) && isTouching)
            {
                Vector3 newPosition = Camera.main.ScreenToWorldPoint(touch.position) + touchOffset;
                newPosition.z = 0; // Keep the GameObject in the correct plane
                transform.position = newPosition;
            }

            currentPosition = transform.position;

            currentPosition.y += 4.5f;

            playerSpeed = currentPosition.y + 2f;
            if (playerSpeed < 3)
            {
                playerSpeed = 3;
            }
        }
    }
}
