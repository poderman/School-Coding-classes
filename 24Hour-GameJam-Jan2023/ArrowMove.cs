using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{

    public float speed;

    public float timer;

    public bool UP;
    public bool Down;
    public bool Right;
    public bool Left;

    private PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        timer = 7;
        
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (UP == true)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Down == true)
            transform.Translate (Vector2.down * speed * Time.deltaTime);
        if (Right == true)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Left == true)
            transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }
}
