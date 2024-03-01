using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class OSCBloom : MonoBehaviour
{
    [SerializeField] public VolumeProfile volumeProfile;
    public void UpdateBloom(string BloomThreshold)
    {
        string[] colorValues = BloomThreshold.Split(',');
        float bloomF = float.Parse(colorValues[0]);
        float thresholdF = float.Parse(colorValues[1]);

        Bloom bloom;
        if(!volumeProfile.TryGet(out bloom)) throw new System.NullReferenceException(nameof(bloom));
        
        Debug.Log("Updating Bloom to: " + bloomF + ", " + thresholdF);
        
        bloom.intensity.Override(bloomF);
        bloom.threshold.Override(thresholdF);
    }  
}
