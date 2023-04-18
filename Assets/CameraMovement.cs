using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform CameraTarget;
    public float pLerp = 10f;
    public float rLerp = 10f;
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, CameraTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, CameraTarget.rotation, pLerp);
    }

}
