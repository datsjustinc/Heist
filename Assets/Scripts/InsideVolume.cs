using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideVolume : MonoBehaviour
{
    public GameObject play;
    
    void Start()
    {
        play.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            play.SetActive(true);
        }
    }
}
