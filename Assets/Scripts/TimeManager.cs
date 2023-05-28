using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public PlayerMove PlayerMove;
    private void Start()
    {
        PlayerMove = GetComponent<PlayerMove>();
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Time.timeScale = 0.2f;
            Time.fixedDeltaTime *= Time.timeScale;
            
        }
        else 
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = 0.02f;
        }       
    }
}
