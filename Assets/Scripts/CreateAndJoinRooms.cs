using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public GameObject ButtonCreate;
    public GameObject ButtonJoin;
    public GameObject InputCreate;
    public GameObject InputJoin;

    public void CreateRoom()
    {
        // trzeba zrobić ze np nazwa lobby minimum 4 znaki - pop up window
        PhotonNetwork.CreateRoom(InputCreate.GetComponent<TMP_InputField>().text);
    }

    public void JoinRoom()
    {
        // obsluga braku lobby - pop up window
        PhotonNetwork.JoinRoom(InputJoin.GetComponent<TMP_InputField>().text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");     //zmienić nazwe sceny z grą na jakąś normalną xd
    }
}
