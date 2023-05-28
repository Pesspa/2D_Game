using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    private FixedJoint _fixedJoint;
    public Rigidbody rigidbody;
    public RopeGun RopeGun;
    public RopeRenderer ropeRenderer;

    public bool isRenderer;
    private Transform playerTransform;

    private void OnCollisionEnter(Collision collision)
    {
        if(_fixedJoint == null)
        {
            _fixedJoint = gameObject.AddComponent<FixedJoint>();
            if (collision.rigidbody)
            {
                RopeGun.currentRopeState = RopeState.active;
                isRenderer = true;
                _fixedJoint.connectedBody = collision.rigidbody;
            }
            RopeGun.CreateSpring();
        }
    }
    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (RopeGun.currentRopeState != RopeState.disabled)
        {
            ropeRenderer.AddRope();
        }
    }
    public void DestroyJoint()
    {
        if(_fixedJoint != null)
        {
            Destroy(_fixedJoint);
            RopeGun.currentRopeState = RopeState.disabled;
            isRenderer=false;
            ropeRenderer.lineRenderer.positionCount = 0;
            gameObject.SetActive(false);
        }
    }
}
