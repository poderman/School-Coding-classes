using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public float LivePlayers;

    public float LiveSpectators;

    //public float LivePlayingPlayers;

    public GameObject NeedMorePlayers;
    public GameObject CurrentSpectators;

    public TMP_Text CurrentPlayers;
    public TMP_Text CurrentSpectatorsText;

    // Start is called before the first frame update
    void Start()
    {
        //LivePlayers += 1;
        LivePlayers = PhotonNetwork.PlayerList.Length;
        Debug.Log("Number of players in room: " + LivePlayers);

        if (LivePlayers == 1)
        {
            NeedMorePlayers.SetActive(true);
            CurrentPlayers.text = "Waiting For More Players " + LivePlayers.ToString("N0") + "/2";
        }
        else if (LivePlayers == 2)
        {
            NeedMorePlayers.SetActive(false);
        }
        else if (LivePlayers >= 3)
        {
            NeedMorePlayers.SetActive(false);
            CurrentSpectators.SetActive(true);

            LiveSpectators = LivePlayers;
            LiveSpectators -= 2;
            CurrentSpectatorsText.text = "Current Spectators " + LivePlayers.ToString("N0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        LivePlayers = PhotonNetwork.PlayerList.Length;

        if (LivePlayers == 1)
        {
            NeedMorePlayers.SetActive(true);
            CurrentPlayers.text = "Waiting For More Players " + LivePlayers.ToString("N0") + "/2";

            CurrentSpectators.SetActive(false);
        }
        /*else if (LivePlayingPlayers == 1);
        {
            LivePlayingPlayers.text = "Waiting For More Players " + LivePlayers.ToString("N0") + "/2";
            NeedMorePlayers.SetActive(true);
        }*/
        else if (LivePlayers == 2)
        {
            NeedMorePlayers.SetActive(false);
            CurrentSpectators.SetActive(false);
        }
        else if (LivePlayers >= 3)
        {
            NeedMorePlayers.SetActive(false);
            CurrentSpectators.SetActive(true);

            LiveSpectators = LivePlayers;
            LiveSpectators -= 2;
            CurrentSpectatorsText.text = "Current Spectators " + LiveSpectators.ToString("N0");

            //LivePlayingPlayers = LivePlayers;
            //LivePlayingPlayers -= LiveSpectators;
        }
    }
}
