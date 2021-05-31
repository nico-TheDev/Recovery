using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    [Range(2, 10)]
    public float transSpeed;
    void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPosition = player.position + offset;
        Vector3 smoothTransition = Vector3.Lerp(transform.position, targetPosition, transSpeed * Time.fixedDeltaTime);
        transform.position = targetPosition;
    }
}
