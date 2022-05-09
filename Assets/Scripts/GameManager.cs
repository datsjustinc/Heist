using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
public class GameManager : MonoBehaviour
{
    public GameObject outsideVolume;
    public Volume volume;
    public ColorAdjustments color;
    public readonly float startSaturation = 75;
    public readonly float endSaturation = -75;
    public bool coroutineRun = false;

    void Start()
    {
        volume = outsideVolume.GetComponent<Volume>();
        volume.profile.TryGet<ColorAdjustments>(out color);
    }

    void Update()
    {
        /*
        if (!coroutineRun && (color.saturation.value > endSaturation))
        {
            StartCoroutine(ChangeWorld());
        }
        */
        color.saturation.value = -75;
    }

    /*
    IEnumerator ChangeWorld()
    {
        coroutineRun = true;
        yield return new WaitForSeconds(1);
        color.saturation.value -= -75;
        coroutineRun = false;
    }
    */
}
