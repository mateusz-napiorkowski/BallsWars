using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void BackToMainMenu(string sceneName)
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene(sceneName);
    }
}
