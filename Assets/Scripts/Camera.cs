using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraà : MonoBehaviour
{
    public Transform playerTrans;

    void Update()
    {
        var target = transform.rotation * Quaternion.Euler(0, 20f, 0);
        transform.position = new Vector3(playerTrans.position.x, playerTrans.position.y, transform.position.z);
        if(Input.mousePosition.x >= 960f)
        {
            playerTrans.rotation = Quaternion.Euler(transform.up * -20f);

            //Quaternion rotY = Quaternion.Euler(Vector3.up * 15f);
            //playerTrans.rotation = rotY;
            //playerTrans.rotation = Quaternion.Lerp(transform.rotation, rotY, Time.deltaTime * -20f);
        }
        else playerTrans.rotation = Quaternion.RotateTowards(transform.rotation, target, Time.deltaTime * 20f);

    }
}
