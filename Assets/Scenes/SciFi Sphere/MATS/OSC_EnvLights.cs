using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSC_EnvLights : MonoBehaviour
{
    public void UpdateColor(string EnvLightsColor)
    {
        string[] colorValues = EnvLightsColor.Split(',');
        float r = float.Parse(colorValues[0]);
        float g = float.Parse(colorValues[1]);
        float b = float.Parse(colorValues[2]);
        //The Alpha value is used as the intensity of the light
        float a = float.Parse(colorValues[3]);
        //Min Intensity: 0.0f
        //Max Intensity: 1000.0f
        a = a * 1000;

        //Debug.Log("Updating EnvLights to: " + r + ", " + g + ", " + b + ", " + a);

        GetComponent<Light>().color = new Color(r, g, b);
        GetComponent<Light>().intensity = a;
    }
}
