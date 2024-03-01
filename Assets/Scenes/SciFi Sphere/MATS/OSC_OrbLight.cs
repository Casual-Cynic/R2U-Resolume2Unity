using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSC_OrbLight : MonoBehaviour
{
    public void UpdateColor(string OrbLightColor)
    {
        string[] colorValues = OrbLightColor.Split(',');
        float r = float.Parse(colorValues[0]);
        float g = float.Parse(colorValues[1]);
        float b = float.Parse(colorValues[2]);
        //The Alpha value is used as the intensity of the light
        float i = float.Parse(colorValues[3]);
        //Min Intensity: 0.0f
        //Max Intensity: 1000.0f
        i = i * 1000;

        //Debug.Log("Updating OrbLight to: " + r + ", " + g + ", " + b + ", " + i);

        GetComponent<Light>().color = new Color(r, g, b);
        GetComponent<Light>().intensity = i;
    }
}
