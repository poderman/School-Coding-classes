using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public float MaxRandomTime = 5f;
    public float MinRandomTime = 3f;

    public float NextSpawnTimer;

    public GameObject[] SpawnLanes;
    public int SpawnLane;

    public GameObject[] SpawnObjects;
    public int SpawnObject;

    public float GameTime;

    // Start is called before the first frame update
    void Start()
    {
        NextSpawnTimer = Random.Range(MinRandomTime, MaxRandomTime);
    }

    // Update is called once per frame
    void Update()
    {
        GameTime += Time.deltaTime;

        if (GameTime <= 10)
        {
            MaxRandomTime = 5f;
            MinRandomTime = 3f;
        }
        else if (GameTime <= 15)
        {
            MaxRandomTime = 4.5f;
            MinRandomTime = 2.5f;
        }
        else if (GameTime <= 20)
        {
            MaxRandomTime = 4f;
            MinRandomTime = 2f;
        }
        else if (GameTime <= 25)
        {
            MaxRandomTime = 3.5f;
            MinRandomTime = 1.5f;
        }
        else if (GameTime <= 30)
        {
            MaxRandomTime = 3f;
            MinRandomTime = 1f;
        }
        else if (GameTime <= 35)
        {
            MaxRandomTime = 2.5f;
            MinRandomTime = 1f;
        }
        else if (GameTime <= 40)
        {
            MaxRandomTime = 2f;
            MinRandomTime = 1f;
        }
        else if (GameTime > 40)
        {
            MaxRandomTime = 1.5f;
            MinRandomTime = 1f;
        }

        NextSpawnTimer -= Time.deltaTime;

        if (NextSpawnTimer <= 0)
        {
            NextSpawnTimer = Random.Range(MinRandomTime, MaxRandomTime);

            SpawnObject = Random.Range(0, SpawnObjects.Length);

            SpawnLane = Random.Range(0, SpawnLanes.Length);

            Instantiate(SpawnObjects[SpawnObject], SpawnLanes[SpawnLane].transform.position, transform.rotation);
        }
    }
}
