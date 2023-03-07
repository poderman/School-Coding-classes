using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject BluePlayerPrefab;
    public GameObject RedPlayerPrefab;

    public float minRedX;
    public float maxRedX;
    public float minRedY;
    public float maxRedY;

    public float minBlueX;
    public float maxBlueX;
    public float minBlueY;
    public float maxBlueY;

    public int LivePlayers;
    public int LivePlayingPlayers;
    public int LiveSpectators;
    
    public int FirstPlayer;

    public GameObject PlayerDisconnected;

    private void Start()
    {
        FirstPlayer = 0;

        LivePlayers = PhotonNetwork.PlayerList.Length;
        //Debug.Log("Number of players in room: " + LivePlayers);

        if (LivePlayers == 1)
        {
            Vector2 randomRedPosition = new Vector2(Random.Range(minRedX, maxRedX), Random.Range(minRedY, maxRedY));
            PhotonNetwork.Instantiate(RedPlayerPrefab.name, randomRedPosition, Quaternion.identity);

            FirstPlayer = 1;
        }
        else if (LivePlayers == 2)
        {
            Vector2 randomBluePosition = new Vector2(Random.Range(minBlueX, maxBlueX), Random.Range(minBlueY, maxBlueY));
            PhotonNetwork.Instantiate(BluePlayerPrefab.name, randomBluePosition, Quaternion.identity);
        }
        else
        {
            //You are now a spectator because people are playing!!!
        }
    }

    void Update()
    {
        LivePlayers = PhotonNetwork.PlayerList.Length;

        if (LivePlayers == 2)
        {
            if (FirstPlayer == 1)
            {
                FirstPlayer = 0;
                LivePlayingPlayers = 2;
            }
        }

        if (FirstPlayer == 0)
        {
            if (LivePlayingPlayers == 1)
            {
                PlayerDisconnected.SetActive(true);
            }
        }

        if (LivePlayers <= 2)
        {
            LiveSpectators = 0;
            LivePlayingPlayers = LivePlayers;
        }
        else if (LivePlayers >= 3)
        {
            LiveSpectators = LivePlayers;
            LiveSpectators -= 2;

            LivePlayingPlayers = LivePlayers;
            LivePlayingPlayers -= LiveSpectators;
        }
        /*if (FirstPlayer == 0)
        {
            if (LivePlayingPlayers == 1)
            {
                PlayerDisconnected.SetActive(true);
            }
        }*/
    }

    /*private void Update()
    {
        if (LivePlayingPlayers -= 1)
        {
            JoinAsPlayerButton.SetActive(true);
        }
    }

    public void PlayAsPlayer()
    {

    }*/

    /*void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
        //LivePlayers = PhotonNetwork.PlayerList.Length;

        //LivePlayingPlayers = LivePlayers;
        //LivePlayingPlayers -= LiveSpectators;

        if (LivePlayingPlayers == 1)
        {
            PlayerDisconnected.SetActive(true);
        }
    }*/
    
}
