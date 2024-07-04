using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Followed Player Movement Tutorial - Link to Video Series for future refreshor
/// https://www.youtube.com/watch?v=gdp-O6z8x28&list=PLD_vBJjpCwJsqpD8QRPNPMfVUpPFLVGg4
/// </summary>
public class PlayerLocomotion : MonoBehaviour
{
    InputManager inputManager;

    Vector3 moveDirection;
    Transform cameraObject;
    Rigidbody playerRigidBody;

    public float movementSpeed = 7.0f;
    public float rotationSpeed = 15.0f;
    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidBody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }
    
    public void HandleAllMovement()
    {
        HandleMovement();
        handleRotation();
    }
    private void HandleMovement()
    {
        moveDirection = cameraObject.forward * inputManager.verticalInput;
        moveDirection = moveDirection + cameraObject.right * inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;
        moveDirection = moveDirection * movementSpeed;

        Vector3 movementVelocity = moveDirection;
        playerRigidBody.velocity = movementVelocity;
    }

    private void handleRotation()
    {
        Vector3 targetDirection = Vector4.zero;

        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection = targetDirection + cameraObject.right * inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero)
        {
            targetDirection = transform.forward;
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
    }
}
