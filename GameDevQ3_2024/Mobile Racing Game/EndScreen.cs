using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TMP_Text HighScoreText;
    public TMP_Text YourScoreText;

    public float HighScore;
    public float YourScore;

    public PointManager PointManager;

    public GameObject YourCar;
    public float rotationSpeed = 90.0f; // Speed of rotation in degrees per second

    private string CurrentCar;
    public Image CarSprite;
    public Sprite[] CarSprites;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        PointManager.LoadHScore();
        HighScore = PointManager.HighScore;

        HighScoreText.text = "High Score: " + HighScore.ToString("N0");
        YourScoreText.text = "Your Score: " + YourScore.ToString("N0");

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
        YourCar.transform.Rotate(new Vector3(0, 0, 1), rotationSpeed * Time.deltaTime);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LeaderBoardButton()
    {
        SceneManager.LoadScene("Leaderboard");
    }
}
