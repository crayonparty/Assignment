using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    public bool StartinVR;
    public GameObject xrOrigin;
    public GameObject FauxPlayer;

    // Start is called before the first frame update
    void Start()
    {
        if(StartinVR)
        {
            var xrSettings = XRGeneralSettings.Instance;
            if (xrSettings == null)
            {
                Debug.Log("XRGeneralSettings is null");
                return;
            }
            var xrManager = xrSettings.Manager;
            if (xrSettings == null)
            {
                Debug.Log("XRManagerSettings is null");
                return;
            }
            var xrLoader = xrManager.activeLoader;
            if (xrSettings == null)
            {
                Debug.Log("XRLoader is null");
                xrOrigin.SetActive(false);
                FauxPlayer.SetActive(true);
                return;
            }
            Debug.Log("XRLoader is not null");
            xrOrigin.SetActive(true);
            FauxPlayer.SetActive(false);
        }
        else
        {
            xrOrigin.SetActive(false);
            FauxPlayer.SetActive(true);
        }
      
    }


}
