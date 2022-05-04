using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultVolume : MonoBehaviour
{
    public GameObject insideVolume;

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            insideVolume.SetActive(true);
        }
    }
}
