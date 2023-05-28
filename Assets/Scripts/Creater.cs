using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Creater : MonoBehaviour
{
    public Renderer[] playerRenderer;
    public GameObject[] Hats;
    public Image imageRenderer;
    public Color imageColor;
    public static int numberOfhats;
    public void ColorChoise()
    {
        imageColor = imageRenderer.color;
        playerRenderer[0].material.color = imageColor;
        playerRenderer[1].material.color = imageColor;

        PlayerPrefs.SetFloat("PlayerColor_R", imageColor.r);
        PlayerPrefs.SetFloat("PlayerColor_G", imageColor.g);
        PlayerPrefs.SetFloat("PlayerColor_B", imageColor.b);
    }
    public void SetHats(int index)
    {
        for(int i = 0; i < Hats.Length; i++)
        {
            if(i == index)
            {
                Hats[i].SetActive(true);
                numberOfhats = i;
            }
            else
            {
                Hats[i].SetActive(false);
            }
        }
    }
    public void StartGame()
    {
        Save();
        SceneManager.LoadScene(1);
    }
    public void Save()
    {

        PlayerPrefs.SetInt("NumberOfHats", numberOfhats);

    }
}
