using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeRenderer : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform ropegunPosition;
    public Transform targetPosition;

    public Hook hook;

    public void AddRope()
    {
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, ropegunPosition.position);
        lineRenderer.SetPosition(1, targetPosition.position);
    }
}
