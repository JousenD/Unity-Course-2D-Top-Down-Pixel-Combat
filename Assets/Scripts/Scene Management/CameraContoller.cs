using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraContoller : Singleton<CameraContoller>
{   
    private CinemachineVirtualCamera cinemachineVirtualCamera;

    private void Start() {
        SetPlayerCameraFollow();
    }

    public void SetPlayerCameraFollow() {
        cinemachineVirtualCamera = FindObjectOfType<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.Follow = PlayerController.Instance.transform;
    }
}
