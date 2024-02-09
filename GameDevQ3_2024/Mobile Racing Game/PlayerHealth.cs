using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public GameObject LostScreen;
    public GameObject ClosePanels;

    public GameObject ExplostionAnimation;

    public float rotationSpeed = 90.0f; // Speed of rotation in degrees per second

    public float timer;
    public float playerPoints;
    private bool CountTimer = true;
    public EndScreen EndScreen;
    public PointManager PointManager;

    public SoundEffectManager SoundEffectManager;

    private string CurrentCar;
    public SpriteRenderer CarSprite;
    public Sprite[] CarSprites;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        FindCarSprite();
    }

    void FindCarSprite()
    {
        CurrentCar = PointManager.CurrentCar;

        if (CurrentCar == CarSprites[index].name)
        {
            CarSprite.sprite = CarSprites[index];
        }
        else
        {
            index += 1;
            if(index >= CarSprites.Length)
            {
                index = 0;
            }
            FindCarSprite();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CountTimer == true)
        {
            timer += Time.deltaTime;
        }

        playerPoints = timer * 10f;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Racer"))
        {
            RacerCrash();
            //Debug.Log("YouLost");
        }
        else if (other.gameObject.CompareTag("OffRoad"))
        {
            OffRoadCrash();

            //LostScreen.SetActive(true);
            //Debug.Log("YouLost");
        }
    }

    public void RacerCrash()
    {
        CountTimer = false;
    
        SoundEffectManager.PlayExplostion();
        ExplostionAnimation.SetActive(true);
        CarSprite.enabled = false;

        PointManager.score = playerPoints;
        PointManager.SaveHScore();

        EndScreen.YourScore = playerPoints;
        ClosePanels.SetActive(true);
    }

    public void OffRoadCrash()
    {
        CountTimer = false;

        SoundEffectManager.PlayCarSkid();

        // Rotate the GameObject around the Z-axis at the specified speed
        transform.Rotate(new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);

        PointManager.score = playerPoints;
        PointManager.SaveHScore();

        EndScreen.YourScore = playerPoints;
        ClosePanels.SetActive(true);
    }
}
