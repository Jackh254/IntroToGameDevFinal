using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Followed Player Movement Tutorial - Link to Video Series for future refreshor
/// https://www.youtube.com/watch?v=gdp-O6z8x28&list=PLD_vBJjpCwJsqpD8QRPNPMfVUpPFLVGg4
/// </summary>
public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    CameraManager cameraManager;
    PlayerLocomotion playerLocomotion;
private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        cameraManager = FindObjectOfType<CameraManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        playerLocomotion.HandleAllMovement();
    }

    //private void LateUpdate()
    //{
    //    cameraManager.FollowTarget();
    //}
}
