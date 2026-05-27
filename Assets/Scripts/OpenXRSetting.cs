using System.Collections;
using System.Collections.Generic;
using Unity.XR.PXR;

//using Unity.XR.OpenXR.Features.PICOSupport;
using UnityEngine;

public class OpenXRSetting : MonoBehaviour
{
    private void Awake()
    {
        //PassthroughFeature.EnableVideoSeeThrough = true;
        PXR_Manager.EnableVideoSeeThrough = true;
    }

    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            //PassthroughFeature.EnableVideoSeeThrough = false;
            PXR_Manager.EnableVideoSeeThrough = false;
        }
        else
        {
            //PassthroughFeature.EnableVideoSeeThrough = true;
            PXR_Manager.EnableVideoSeeThrough = true;
        }
    }
}
