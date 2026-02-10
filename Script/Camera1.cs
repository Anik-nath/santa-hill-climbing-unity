using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    public Transform target;
    public float yoffset = 1f;
    public float followSpeed = 2f;

    void Update()
    {
        Vector3 newPos = new Vector3(
            target.position.x,
            target.position.y + yoffset,
            -10f
        );

        transform.position = Vector3.Slerp(
            transform.position,
            newPos,
            followSpeed * Time.deltaTime
        );
    }
}
