using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverSpawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnMinInterval = 5.0f;
    public float spawnMaxInterval = 10.0f;
    private float spawnTimer = 0f;

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            spawnTimer = Random.Range(spawnMinInterval, spawnMaxInterval);
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
}
