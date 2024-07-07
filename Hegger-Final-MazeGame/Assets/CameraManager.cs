using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform targetTransform;  // The object the camera will follow
    private Vector3 cameraFollowVelocity = Vector3.zero;

    public float cameraFollowSpeed = 0.2f;

    public float lookAngle;  // Camera looking up and down
    public float pivorAngle; // Camera looking left and right

    private void Awake()
    {
        targetTransform = FindObjectOfType<PlayerManager>().transform;
    }
    public void FollowTarget()
    {
        Vector3 targetPostition = Vector3.SmoothDamp(transform.position, targetTransform.position, ref cameraFollowVelocity, cameraFollowSpeed);
        
        transform.position = targetPostition;
    }

    public void RotateCamera()
    {
        //lookAngle = lookAngle + (mouseXInput * cameraLookSpeed);
        //pivorAngle = pivorAngle - (mouseYInput * cameraPivotSpeed);
    }
}
