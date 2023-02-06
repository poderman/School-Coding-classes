using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShoot : MonoBehaviour
{
    public GameObject arrow;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
            timer = Random.Range(1,4);
        }
    }
}

