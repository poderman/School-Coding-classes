using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckManager : MonoBehaviour
{
    public PointManager PointManager;

    public GameObject Confetti;

    public float time;
    public int timeOn;

    public GameObject Puck;
    public GameObject PuckRespawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        PointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        PuckRespawnPoint = GameObject.Find("PuckRespawnPoint");
        Puck = GameObject.Find("Puck");

        timeOn = 0;
        time = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeOn == 1)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            Puck.transform.position = PuckRespawnPoint.transform.position;

            timeOn = 0;
            time = 4;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TopScoreNet"))
        {
            PointManager.RedScore += 1;
            Instantiate(Confetti, transform.position, Quaternion.identity);
            timeOn = 1;
        }
        if (other.gameObject.CompareTag("BottomScoreNet"))
        {
            PointManager.BlueScore += 1;
            Instantiate(Confetti, transform.position, Quaternion.identity);
            timeOn = 1;
        }
    }

}
