using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public GameObject SettingsMenuPanel;
    public GameObject MainMenuPanel;

    public GameObject MainPanel;
    public GameObject CreditsPanel;

    public PointManager PointManager;

    public TMP_Text VolumeText;
    public Slider VolumeSlider;

    public float MasterVolume;
    public string UserName;
    public string CurrentCar;

    // Start is called before the first frame update
    void Start()
    {
        CurrentCar = PointManager.CurrentCar;

        MasterVolume = PointManager.MasterVolume;
        VolumeSlider.value = MasterVolume;
    }

    // Update is called once per frame
    void Update()
    {
        MasterVolume = VolumeSlider.value;

        float VolumePercent = MasterVolume * 100f;
        VolumeText.text = "Master Volume: " + VolumePercent.ToString("N0") + "%";
    }

    public void SaveAndExitButton()
    {
        PointManager.MasterVolume = MasterVolume;
        PointManager.CurrentCar = CurrentCar;

        PointManager.SaveHScore();

        SettingsMenuPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }

    public void MainMenuButton()
    {
        SettingsMenuPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }

    public void CreditsButton()
    {
        MainPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    public void CreditsBackButton()
    {
        CreditsPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
}
