using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Define the speed at which the player moves

    bool wasJustClicked = true;
    bool canMove = false;
    Vector2 playerSize;
    private Vector3 targetPosition;

    Rigidbody2D rb;

    PhotonView view;

    public float LivePlayers;

    // Use this for initialization
    void Start()
    {
        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;

        rb = GetComponent<Rigidbody2D>();

        

        view = GetComponent<PhotonView>();

        LivePlayers = PhotonNetwork.PlayerList.Length;
        Debug.Log("Number of players in room: " + LivePlayers);

        //LivePlayers = 2f;

        if (LivePlayers == 2)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked)
            {
                wasJustClicked = false;

                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = transform.position.z; // Make sure the z position is the same as the player's

                // If we're not currently moving towards the mouse, set the target position to the mouse position
                if (canMove)
                {
                    targetPosition = mousePosition;
                    canMove = true;
                }
                // Gradually change the player's position towards the target position
                Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
                newPosition.z = transform.position.z;

                // If the mouse has moved, update the target position
                if (mousePosition != targetPosition)
                {
                    targetPosition = mousePosition;
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                rb.MovePosition(mousePos);
            }
        
            else
            {
                wasJustClicked = true;
            }
        }
        
    }
}
