using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class GameManager : MonoBehaviour
{
    public GameObject outsideVolume;
    public Volume volume;

    void Start()
    {
        volume = outsideVolume.GetComponent<Volume>();
    }

    void Update()
    {

    }
}
