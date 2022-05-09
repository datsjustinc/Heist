using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject camera1;
    public GameObject camera2;
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            player1.SetActive(false);
            camera1.SetActive(false);
            player2.SetActive(true);
            camera2.SetActive(true);
        }
    }
}
