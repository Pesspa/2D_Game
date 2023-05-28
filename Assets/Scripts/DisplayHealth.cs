using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHealth : MonoBehaviour
{
    public GameObject healthIcon;
    public List<GameObject> healthList = new List<GameObject>();

    public void SetupHealth(float maxHp)
    {
        for(float i = 0; i < maxHp; i++)
        {
            GameObject newIcon = Instantiate(healthIcon, transform);
            healthList.Add(newIcon);
        }
    }
    public void ShowHealthPoint(float hp)
    {
        for(int i = 0; i < healthList.Count; i++)
        {
            if(i < hp)
            {
                healthList[i].SetActive(true);
            }
            else healthList[i].SetActive(false);
        }
    }
}
