using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultVolume : MonoBehaviour
{
    public GameObject insideVolume;
    public GameObject play;
    
    void Start()
    {
        play.SetActive(false);
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            insideVolume.SetActive(true);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            play.SetActive(true);
        }
    }
}
