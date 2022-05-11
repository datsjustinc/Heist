using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamDetection : MonoBehaviour
{
    public GameObject spawn;
    public bool inside;

    public StarterAssets.ThirdPersonController thirdPersonController;

    void Update()
    {
        //Debug.Log(transform.position + "+" + spawn.transform.position);
        /*
        if(inside)
        {
            Debug.Log("Teleporting");
            transform.position = spawn.transform.position;
            inside = false;
        }
        */
    }
    void OnTriggerStay(Collider other)
    { 
        if(other.gameObject.CompareTag("camera")) 
        {
            thirdPersonController.enabled = false;
            transform.position = spawn.transform.position;
            thirdPersonController.enabled = true;
        }
    }

    void OnTriggerEnter (Collider other) 
    {
        if(other.gameObject.CompareTag("camera")) 
        {
            thirdPersonController.enabled = false;
            transform.position = spawn.transform.position;
            thirdPersonController.enabled = true;
        }
    }
}
