using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraRotate : MonoBehaviour
{
    public float LivePlayers;

    // Start is called before the first frame update
    void Start()
    {
        LivePlayers = PhotonNetwork.PlayerList.Length;
        //Debug.Log("Number of players in room: " + LivePlayers);

        if (LivePlayers == 2)
        {
            transform.Rotate(0f, 0f, 180f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
