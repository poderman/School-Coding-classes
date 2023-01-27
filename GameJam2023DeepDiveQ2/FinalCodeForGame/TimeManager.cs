using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public TMP_Text time;
    //public GameObject player;

    //public string ChooseAScene;

    public Timer Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + Timer.timer.ToString("N0");
    }
}
