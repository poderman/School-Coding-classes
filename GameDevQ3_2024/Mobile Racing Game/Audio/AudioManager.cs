using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public PointManager PointManager;

    public AudioSource AudioSource;

    public AudioClip[] GameMusic;

    public float MasterVolume;

    private int index;
    private int lastIndex;

    private bool isFirst = true;

    // Start is called before the first frame update
    void Start()
    {
        PointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        AudioSource = GetComponent<AudioSource>();

        isFirst = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayMusic();
    }

    void PlayMusic()
    {
        MasterVolume = PointManager.MasterVolume;
        AudioSource.volume = MasterVolume;

        if (!AudioSource.isPlaying || isFirst == true)
        {
            /*if (index >= GameMusic.Length)
            {
                index = 0;
            }
            else
            {
                index++;
            }*/

            index = Random.Range(0, GameMusic.Length);

            if (index == lastIndex)
            {
                PlayMusic();
            }
            else
            {
                AudioSource.clip = GameMusic[index]; // Set the clip
                AudioSource.Play(); // Play the clip
                lastIndex = index;

                isFirst = false;
            }
        }
    }
}

