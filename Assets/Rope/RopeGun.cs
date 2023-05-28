using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RopeState
{
    fly,
    disabled,
    active
}

public class RopeGun : MonoBehaviour
{
    public RopeRenderer ropeRenderer;
    public Transform spawn;
    public float speed;
    public Hook Hook;
    public Collider HookCollider;
    public Collider PlayerCollider;
    public float ropeLenght;
    public float _maxRopeLenght = 20f;
    public RopeState currentRopeState;
    public PlayerMove PlayerMove;

    private SpringJoint _springJoint;
    private void Start()
    {
        currentRopeState = RopeState.disabled;    
        Physics.IgnoreCollision(HookCollider, PlayerCollider);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(2))
        {
            Shot();
        }
        if(currentRopeState == RopeState.fly)
        {
            ropeLenght = Vector3.Distance(spawn.position, Hook.transform.position);
            ropeRenderer.AddRope();
            if (ropeLenght > _maxRopeLenght)
            {    
                ReturnHook();
            }
        }
        if(Input.GetKey(KeyCode.Space) && currentRopeState == RopeState.active) // должно быть active
        {
            Hook.DestroyJoint();
            PlayerMove.Jump();
        }
        if(currentRopeState == RopeState.disabled)
        {
            Destroy(_springJoint);
            
        }
    }
    void Shot()
    {
        if(_springJoint != null)
        {
            Destroy(_springJoint);
        }
        Hook.gameObject.SetActive(true);
        Hook.DestroyJoint();
        Hook.transform.position = spawn.position;
        Hook.transform.rotation = spawn.rotation;
        Hook.rigidbody.velocity = spawn.forward * speed;
        currentRopeState = RopeState.fly;
    }
    public void CreateSpring()
    {
        if (_springJoint == null)
        {
            _springJoint = gameObject.AddComponent<SpringJoint>();
            _springJoint.autoConfigureConnectedAnchor = false;
            _springJoint.connectedAnchor = Vector3.zero;
            _springJoint.spring = 20f;
            _springJoint.damper = 1f;
            _springJoint.connectedBody = Hook.rigidbody;
            ropeLenght = Vector3.Distance(spawn.position, Hook.transform.position);
            _springJoint.maxDistance = ropeLenght;
            currentRopeState = RopeState.active;
        }
    }
    private void ReturnHook()
    {
        Hook.rigidbody.velocity = Vector3.zero;
        Vector3 direction = spawn.position - Hook.transform.position;
        Hook.rigidbody.velocity = direction;
    }
}

