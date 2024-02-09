using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarSelect : MonoBehaviour
{
    public SettingsMenu SettingsMenu;

    public TMP_Text CurrentCarText;

    public Image CurrentCarSpriteRender;

    public string SelectedCar;
    public Sprite[] CarSprites;
    //public string SelectedCarName;

    public int index;

    // Start is called before the first frame update
    void Start()
    {
        SelectedCar = SettingsMenu.CurrentCar;

        FindCarSprite();
    }

    void FindCarSprite()
    {
        if (SelectedCar == CarSprites[index].name)
        {
            //Do nothing
        }
        else
        {
            index += 1;
            if(index > CarSprites.Length)
            {
                index = 0;
            }
            FindCarSprite();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //SelectedCarName = CarSprites[index].name;
        CurrentCarText.text = "Current Car: " + SettingsMenu.CurrentCar;

        CurrentCarSpriteRender.sprite = CarSprites[index];
    }

    public void LeftCarButton()
    {
        index -= 1;
        if (index < 0)
        {
            index = CarSprites.Length - 1;
        }

        SelectedCar = CarSprites[index].name;

    }

    public void RightCarButton()
    {
        index += 1;
        if (index >= CarSprites.Length)
        {
            index = 0;
        }

        SelectedCar = CarSprites[index].name;
    }

    public void SelectCarButton()
    {
        //CurrentCar = SelectedCar;
        SettingsMenu.CurrentCar = SelectedCar;
    }
}
