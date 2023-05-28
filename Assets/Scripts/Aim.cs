using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Aim : MonoBehaviour
{
    public Camera cameraMain;
    public GameObject aim;

    public GameObject gunObject;

    private void LateUpdate()
    {
        //gunObj.transform.rotation = Quaternion.LookRotation(aim.transform.position, Vector3.up);
        Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 50f, Color.yellow);
        Plane plane = new Plane(Vector3.back, Vector3.zero);

        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);

        aim.transform.position = point;

        Vector3 toAim = aim.transform.position - transform.position;
        gunObject.transform.rotation = Quaternion.LookRotation(toAim);  

    }
}
