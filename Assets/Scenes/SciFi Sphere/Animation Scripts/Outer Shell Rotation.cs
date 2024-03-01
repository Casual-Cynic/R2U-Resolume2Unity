using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterShellRotation : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 30.0f;
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }

    public void OscSetRotationSpeed(float oscSpeed)
    {
        rotationSpeed = oscSpeed;
    }
}
