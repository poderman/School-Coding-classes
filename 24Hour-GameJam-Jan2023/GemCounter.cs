using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCounter : MonoBehaviour
{
    public int gemCounter;
    public GameObject FindGem;

    public TMP_Text GemText;
    // Start is called before the first frame update
    void Start()
    {
        gemCounter = 0;
    }

    // Update is called once per frame
    public void ChangeGem(int Gems)
    {
        gemCounter += Gems;
        GemText.text = gemCounter.ToString();
    }
}
