using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TransferOwnerShip : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PhotonView photonView = GetComponent<PhotonView>();

            if (photonView != null && photonView.IsMine)
            {
                photonView.TransferOwnership(collision.gameObject.GetComponent<PhotonView>().Controller);
            }
        }
    }
}
