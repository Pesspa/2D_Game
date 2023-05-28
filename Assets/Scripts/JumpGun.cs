using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGun : MonoBehaviour
{
    public Rigidbody playerBody;
    public float speed;
    public Transform start;
    public Gun pistol;

    public float maxCharge = 3f;
    private float _currentCharge;
    private bool _isCharge;

    public ChargeIcon ChargeIcon;
    void Update()
    {
        if (_isCharge) 
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                playerBody.AddForce(-start.forward * speed, ForceMode.VelocityChange);
                pistol.Shot();
                _currentCharge = 0;
                _isCharge = false;
                ChargeIcon.StartCharge();
            }
        }
        else
        {
            _currentCharge += Time.deltaTime;
            ChargeIcon.SetCharge(_currentCharge, maxCharge);
            if(_currentCharge >= maxCharge)
            {
                _isCharge = true;
                ChargeIcon.StopCharge();
            }
        }
    }
}
