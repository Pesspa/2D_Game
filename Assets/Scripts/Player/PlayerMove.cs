using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform hatTransform;
    public Rigidbody playerBody;
    public float speed;
    public float jumpForce;
    public float friction;
    public bool onFloor;
    public float maxSpeed;
    public float angle;

    private int timeForJump;
    public Transform playerTransform;
    private void OnCollisionStay(Collision collision)
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 10);
        angle = Vector3.Angle(collision.contacts[0].normal, Vector3.up);
        if(angle < 45f)
        {
            onFloor = true;
            playerBody.freezeRotation = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        onFloor = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.C) || onFloor == false)
        {
            playerTransform.localScale = Vector3.Lerp(playerTransform.localScale, new Vector3(1f, 0.6f, 1f), Time.deltaTime * 10f);
        }
        else playerTransform.localScale = Vector3.Lerp(playerTransform.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 10f);
    }
    private void FixedUpdate()
    {
        float speedOnFly = 1f;
        if (Input.GetAxis("Horizontal") != 0 && playerBody.velocity.x >= maxSpeed) speedOnFly = 0f;
        if (Input.GetAxis("Horizontal") != 0 && playerBody.velocity.x <= -maxSpeed) speedOnFly = 0f;

        if (onFloor == false) speedOnFly = 0.05f;

        playerBody.AddForce(Input.GetAxis("Horizontal") * speed * speedOnFly, 0f, 0f, ForceMode.VelocityChange);
        if (onFloor)
        {
            playerBody.AddForce(-playerBody.velocity.x * friction, 0f, 0f, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.Space) && onFloor)
        {
            timeForJump = 0;
            Jump();
        }
        if(timeForJump == 1 && onFloor == false)
        {
            playerBody.freezeRotation = false;
            playerBody.AddTorque(Vector3.forward * 10f, ForceMode.VelocityChange);
        }
    }
    public void Jump()
    {
        playerBody.AddForce(0f, jumpForce, 0f, ForceMode.VelocityChange);
        timeForJump += 1;
    }
}
