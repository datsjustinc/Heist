using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamDetection : MonoBehaviour
{
    public GameObject spawn;
    public bool inside;

    void Update()
    {
        if(inside)
        {
            transform.position = spawn.transform.position;
            inside = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "camera")
        {
            Debug.Log("Hit");
            inside = true;
        }
    }
}
