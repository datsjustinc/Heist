using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
public class GameManager : MonoBehaviour
{
    public GameObject outsideVolume;
    public GameObject insideVolume;
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
        if (insideVolume.activeSelf && !coroutineRun && (color.saturation.value > endSaturation))
        {
            StartCoroutine(ChangeWorld());
        }
    }

    IEnumerator ChangeWorld()
    {
        coroutineRun = true;
        yield return new WaitForSeconds(2);
        color.saturation.value -= 1;
        coroutineRun = false;
    }
}
