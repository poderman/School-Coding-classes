using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    public AudioSource AudioSource;
    public PointManager PointManager;
    public float MasterVolume;

    public AudioClip ButtonClick;
    public AudioClip Explostion;
    public AudioClip CarSkid;

    // Start is called before the first frame update
    void Start()
    {
        PointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    void Update()
    {
        MasterVolume = PointManager.MasterVolume;
        AudioSource.volume = MasterVolume;
    }

    public void PlayButtonClick()
    {
        AudioSource.clip = ButtonClick;
        AudioSource.Play();
    }

    public void PlayExplostion()
    {
        AudioSource.clip = Explostion;
        AudioSource.Play();
    }

    public void PlayCarSkid()
    {
        AudioSource.clip = CarSkid;
        AudioSource.Play();
    }
}
