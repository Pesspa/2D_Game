using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform playerHeadTransform;
    public Transform aimTransform;
    void Update()
    {
        float angle;
        transform.position = new Vector3(playerHeadTransform.position.x, playerHeadTransform.position.y, transform.position.z);
        if (playerHeadTransform.position.x <= aimTransform.position.x)
        {
            angle = -45f;
        }
        else
            angle = 45f;

        playerHeadTransform.rotation = Quaternion.Lerp(playerHeadTransform.rotation, Quaternion.Euler(Vector3.up * angle), Time.deltaTime * 10f);
    }

}
