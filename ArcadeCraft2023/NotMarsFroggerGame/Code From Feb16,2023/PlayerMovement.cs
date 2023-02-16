using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector2 targetTile;

    private Vector2 currentTile;
    private Vector2 destination;

    void Start()
    {
        currentTile = transform.position;
        destination = currentTile;
    }

    void Update()
    {
        if (transform.position.x == destination.x && transform.position.y == destination.y)
       {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                targetTile = new Vector2(currentTile.x, currentTile.y + 1);
                currentTile = transform.position;
                destination = targetTile * speed * Time.deltaTime + currentTile;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                targetTile = new Vector2(currentTile.x, currentTile.y - 1);
                currentTile = transform.position;
                destination = targetTile * speed * Time.deltaTime + currentTile;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                targetTile = new Vector2(currentTile.x - 1, currentTile.y);
                currentTile = transform.position;
                destination = targetTile * speed * Time.deltaTime + currentTile;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                targetTile = new Vector2(currentTile.x + 1, currentTile.y);
                currentTile = transform.position;
                destination = targetTile * speed * Time.deltaTime + currentTile;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }
}
