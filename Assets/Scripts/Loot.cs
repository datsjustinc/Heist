using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public GameObject[] loot;
    public GameObject obstacleVolume;
    public GameObject outsideVolume;
    public GameObject insideVolume;
    public GameObject colorVolume;
    public GameObject end;
    public int count = 0;
    public GameObject player2;
    public GameObject player3;
    public GameObject camera2;
    public GameObject camera3;
    private AudioSource money;

    void Start()
    {
        end.SetActive(false);
        money = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (count == 13)
        {
            obstacleVolume.SetActive(false);
            end.SetActive(true);
            outsideVolume.SetActive(false);
            insideVolume.SetActive(false);
            colorVolume.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Loot"))
        {
            money.Play();
            Destroy(other.gameObject);
            count+=1;
        }

        if (other.CompareTag("End"))
        {
            player2.SetActive(false);
            camera2.SetActive(false);
            player3.SetActive(true);
            camera3.SetActive(true);
        }
    }
}
