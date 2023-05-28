using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float rocketSpeed;
    public float speedRocketRotate;

    private Transform player;

    void Start()
    {
        player = FindObjectOfType<PlayerMove>().transform;
    }
    void Update()
    {
        Vector3 move = transform.position + Vector3.forward * Time.deltaTime * rocketSpeed;
        move.z = 0;
        transform.position = move;

        transform.position += transform.forward * rocketSpeed * Time.deltaTime;  
        Vector3 toPlayer = player.position - transform.position;
        Quaternion target = Quaternion.LookRotation(toPlayer, Vector3.right);
        transform.rotation = Quaternion.Lerp(transform.rotation, target, speedRocketRotate * Time.deltaTime);
    }
}
