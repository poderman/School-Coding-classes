using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 1;
    public float range = 3;

    float startingX;
    int direction = 1;

    public SpriteRenderer spriteRenderer;
    public bool facingRight;

    public Transform glitchPoint;

    // Start is called before the first frame update
    void Start()
    {
        startingX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime * direction);
        if(transform.position.x < startingX || transform.position.x > startingX + range)
        {

            direction *= -1;
            if (facingRight)
            {
                spriteRenderer.flipX = true;
                facingRight = false;
            }
            else
            {
                spriteRenderer.flipX = false;
                facingRight = true;
            }
        }

        if(transform.position.x > startingX + range + 2)
        {
            gameObject.transform.position = glitchPoint.position;
        }

        if(transform.position.x < startingX - 2)
        {
            gameObject.transform.position = glitchPoint.position;
        }

    }
}
