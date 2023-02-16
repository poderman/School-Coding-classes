using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverMovementRight : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
