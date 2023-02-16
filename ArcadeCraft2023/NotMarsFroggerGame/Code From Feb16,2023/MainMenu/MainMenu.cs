using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject QuitScreenObject;
    public GameObject MainMenuScreen;

    public string Play1Player;
    public string Play2Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame1Player()
    {
        SceneManager.LoadScene(Play1Player);
    }

    public void StartGame2Player()
    {
        SceneManager.LoadScene(Play2Player);
    }

    public void Quit()
    {
        MainMenuScreen.SetActive(false);
        QuitScreenObject.SetActive(true);
    }
}
