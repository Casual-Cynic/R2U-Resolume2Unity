using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimation : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    [SerializeField] CinemachineVirtualCamera virtualCamera;

    void Update()
    {
        var dolly = virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
        dolly.m_PathPosition += rotationSpeed * Time.deltaTime;
    }

    public void OscSetRotationSpeed(float oscSpeed)
    {
        rotationSpeed = oscSpeed;
        //Debug.Log("Camera rotation speed set to " + rotationSpeed);
    }
}
