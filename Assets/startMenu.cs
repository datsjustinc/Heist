using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMenu : MonoBehaviour
{
    public GameObject startScreenUI;
    public GameObject startVolume;
    public GameObject outsideVolume;
    public GameObject startCamera;
    public GameObject mainCamera;
    public GameObject player;
   
    public void exitStart()
    {
        startScreenUI.SetActive(false);
        startVolume.SetActive(false);
        outsideVolume.SetActive(true);
        startCamera.SetActive(false);
        mainCamera.SetActive(true);
        player.SetActive(true);
    }
}
