using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyY : MonoBehaviour
{
    public float speed = 1;
    public float range = 3;

    float startingY;
    int direction = 1;

    public Transform glitchPoint;

    // Start is called before the first frame update
    void Start()
    {
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * direction);
        if (transform.position.y < startingY || transform.position.y > startingY + range)
        {

            direction *= -1;
        }
    }
}