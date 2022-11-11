using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
 
public class collectiblesBehaviour : MonoBehaviour
{
    public CinemachineFreeLook CinemachineCamera;
    public CinemachineFreeLook.Orbit[] m_Orbits;
    void OnTriggerEnter(Collider player){
        Vector3 scaleChange = new Vector3(1f, 1f, 1f);
        player.transform.localScale += scaleChange;
        Destroy(gameObject);
        // CinemachineCamera = GetComponent<CinemachineFreeLook>();
        // CinemachineCamera = GetCinemachineComponent<CinemachineFreeLook>();
        // CinemachineCamera.GetRig(0).GetCinemachineComponent<CinemachineComposer>().m_ScreenX = 10;
        // CinemachineCamera.GetRig(1).GetCinemachineComponent<CinemachineComposer>().m_ScreenX = 10;
        // CinemachineCamera.GetRig(2).GetCinemachineComponent<CinemachineComposer>().m_ScreenX = 10;
        // print(CinemachineCamera.GetRig(1));
        // print(m_Orbits.Length);
        // m_Orbits.Array.data[1].m_Radius = 10;
    }
}