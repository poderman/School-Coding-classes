using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int HighScore;

    public int BlueScore;
    public int RedScore;

    public TMP_Text BlueScoreText;
    public TMP_Text RedScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerData data = SaveSystem.LoadScore();
        //HighScore = data.HighScore;

        //SaveSystem.SaveScore(this);


    }

    // Update is called once per frame
    void Update()
    {
        BlueScoreText.text = "Blue Goals: " + BlueScore.ToString("N0");
        RedScoreText.text = "Red Goals: " + RedScore.ToString("N0");
    }
}



/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class PointManager : MonoBehaviourPunCallbacks
{
    public int HighScore;

    public int BlueScore;
    public int RedScore;

    private const string BLUE_SCORE_KEY = "BlueScore";
    private const string RED_SCORE_KEY = "RedScore";

    public TMP_Text BlueScoreText;
    public TMP_Text RedScoreText;

    private int _blueScore;
    private int _redScore;

    void Start()
    {
        // Get the initial scores from the room properties
        Hashtable roomProps = PhotonNetwork.CurrentRoom.CustomProperties;
        _blueScore = roomProps.ContainsKey(BLUE_SCORE_KEY) ? (int)roomProps[BLUE_SCORE_KEY] : 0;
        _redScore = roomProps.ContainsKey(RED_SCORE_KEY) ? (int)roomProps[RED_SCORE_KEY] : 0;

        // Update the score display
        UpdateScoreDisplay();
    }

    public void AddBlueScore()
    {
        _blueScore++;

        // Update the room property with the new score
        Hashtable props = new Hashtable();
        props[BLUE_SCORE_KEY] = _blueScore;
        PhotonNetwork.CurrentRoom.SetCustomProperties(props);
    }

    public void AddRedScore()
    {
        _redScore++;

        // Update the room property with the new score
        Hashtable props = new Hashtable();
        props[RED_SCORE_KEY] = _redScore;
        PhotonNetwork.CurrentRoom.SetCustomProperties(props);
    }

    public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
    {
        // Check if the scores have changed
        if (propertiesThatChanged.ContainsKey(BLUE_SCORE_KEY))
        {
            _blueScore = (int)propertiesThatChanged[BLUE_SCORE_KEY];
        }

        if (propertiesThatChanged.ContainsKey(RED_SCORE_KEY))
        {
            _redScore = (int)propertiesThatChanged[RED_SCORE_KEY];
        }

        // Update the score display
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        BlueScoreText.text = "Blue Goals: " + _blueScore.ToString("N0");
        RedScoreText.text = "Red Goals: " + _redScore.ToString("N0");
    }
}

*/
