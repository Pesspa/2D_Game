using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAmmunition : MonoBehaviour
{

    public Gun[] guns;
    public int gunIndex;
    private void Start()
    {
        TakeGunByIndex(gunIndex);
    }
    private void Update()
    {
        ChangeGun();
        TakeGunByIndex(gunIndex);
    }
    public void TakeGunByIndex(int indexOfGun)
    {
        for (int i = 0; i < guns.Length; i++)
        {
            if(indexOfGun == i)
                guns[i].gameObject.SetActive(true);
            else
                guns[i].gameObject.SetActive(false);
        }        
    }
    public void AddBullets(int bullets, int index)
    {
        guns[index].AddBullet(bullets);
    }
    public void ChangeGun()
    {
        if (Input.GetKey(KeyCode.Q)) 
            gunIndex = 0;
         
        if (Input.GetKey(KeyCode.E))
            gunIndex = 1;
    }
}
