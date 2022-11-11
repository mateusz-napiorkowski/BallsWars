using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Photon.Pun;

public class objectSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = UnityEngine.Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPos = new Vector3(UnityEngine.Random.Range(-49, 49), UnityEngine.Random.Range(1, 99), UnityEngine.Random.Range(-49, 49));

            // resp kulek na serwerze
            PhotonNetwork.Instantiate(myObjects[randomIndex].name, randomSpawnPos, Quaternion.identity);
        }
    }

}
