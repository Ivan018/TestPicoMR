using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenXR.Features.PICOSupport;
using UnityEngine;

public class OpenXRSetting : MonoBehaviour
{
    private void Awake()
    {
        PassthroughFeature.EnableVideoSeeThrough = true;
    }

    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            PassthroughFeature.EnableVideoSeeThrough = false;
        }
        else
        {
            PassthroughFeature.EnableVideoSeeThrough = true;
        }
    }
}
