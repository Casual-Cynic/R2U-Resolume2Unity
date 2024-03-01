using UnityEngine;

public class OSC_EmissiveUpdater : MonoBehaviour
{
    [SerializeField] public Material EmissiveMat;

    public void UpdateEmission(string ArenaColor)
    {
        string[] colorValues = ArenaColor.Split(',');
        float r = float.Parse(colorValues[0]);
        float g = float.Parse(colorValues[1]);
        float b = float.Parse(colorValues[2]);
        //The Alpha value is used as the intensity of the emission
        float a = float.Parse(colorValues[3]);
        a = a * 10;

        //Debug.Log("Updating Emission to: " + r + ", " + g + ", " + b + ", " + a);

        EmissiveMat.SetColor("_EmissionColor", new Color(r, g, b)*a);
    }
}
