using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeIcon : MonoBehaviour
{
    public Image backGround;
    public Image frontGround;
    public Text secondsCount;

    public void StartCharge()
    {
        frontGround.color = new Color(1f, 1f, 1f, 0.2f);
        backGround.enabled = true;
        secondsCount.enabled = true;
    }
    public void StopCharge()
    {
        frontGround.color = new Color(1f, 1f, 1f, 1f);
        backGround.enabled = false;
        secondsCount.enabled = false;
    }
    public void SetCharge(float currentCharge, float maxCharge)
    {
        backGround.fillAmount = currentCharge / maxCharge;
        secondsCount.text = currentCharge.ToString("0.0");
    }
}
