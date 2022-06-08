using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Range(2,10)]
    public float smoothFactor;
    public Transform target;
    public Vector3 offset;
    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position,targetPosition,smoothFactor*Time.fixedDeltaTime);
        transform.position = targetPosition;
    }
}
