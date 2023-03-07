using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Realtime;
using Photon.Pun;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        if(PhotonNetwork.IsConnected)
        {
            SceneManager.LoadScene("Lobby");
        }
        else
        {
            SceneManager.LoadScene("Loading");
        }
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }


    public void GitHubLink()
    {
        Application.OpenURL("https://github.com/poderman/School-Coding-classes/tree/main/ArcadeCraft2023/IceHockeyGame/FinalGameCode");
    }

    public void ItchioLink()
    {
        Application.OpenURL("https://powderman.itch.io/airhockey");
    }
}
