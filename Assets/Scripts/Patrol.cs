using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum Direction
{
    Left, Right
}

public class Patrol : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;

    public float speed;
    public Direction currentDirection;

    public UnityEvent onLeftTarget;
    public UnityEvent onRightTarget;

    private bool _isStoped;
    public float timeStop;

    public Transform rayStart;
    private void Start()
    {
        leftPoint.parent = null;
        rightPoint.parent = null;
    }
    void Update()
    {
        if(_isStoped == true)
        {
            return;
        }
        if (currentDirection == Direction.Left)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            if (transform.position.x < leftPoint.position.x)
            {
                currentDirection = Direction.Right;
                _isStoped = true;
                Invoke(nameof(ContinuePatrol), timeStop);
                onRightTarget.Invoke();
            }
        }
        else
        {
            transform.position -= Vector3.left * speed * Time.deltaTime;
            if(transform.position.x > rightPoint.position.x)
            {
                currentDirection = Direction.Left;
                _isStoped = true;
                Invoke(nameof(ContinuePatrol), timeStop);
                onLeftTarget.Invoke();
            }
        }
        RaycastHit hit;
        if(Physics.Raycast(rayStart.position, Vector3.down, out hit))
        {
            transform.position = hit.point;
        }
    }
    void ContinuePatrol()
    {
        _isStoped = false;

    }
}
