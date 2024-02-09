using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackScroll : MonoBehaviour
{
    private Vector2 startPosition;
    public float scrollSpeed = 5f;
    public float loopDistance = 10f;

    //public PlayerMovement PlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //scrollSpeed = PlayerMovement.playerSpeed;

        //Calculates where the screen should be
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, loopDistance);

        //Moves the screen in place
        transform.position = startPosition + Vector2.down * newPosition;
    }
}
