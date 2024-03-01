using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerShellRotation : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 30.0f;
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }

    public void OscSetRotationSpeed(float oscSpeed)
    {
        rotationSpeed = oscSpeed;
    }
}
