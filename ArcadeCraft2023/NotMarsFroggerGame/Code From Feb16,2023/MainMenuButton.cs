using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public string ChooseAScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChoiceOfAScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(ChooseAScene);
    }
}
