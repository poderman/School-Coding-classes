using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float maxTime = 60;
    public float currentTime;

    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        timer.SetMaxTimer(maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        timer.SetTimer(currentTime);
    }
}
