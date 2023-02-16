using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScreen : MonoBehaviour
{
    public GameObject MainMenuScreen;
    public GameObject QuitScreenObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YesQuit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void NoDontQuit()
    {
        MainMenuScreen.SetActive(true);
        QuitScreenObject.SetActive(false);
    }
}
