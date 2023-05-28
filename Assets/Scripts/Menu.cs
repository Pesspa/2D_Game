using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuWindow;
    public GameObject menuButton;

    public MonoBehaviour[] componentsToDisable;
    public void OpenMenu()
    {
        menuWindow.SetActive(true);
        menuButton.SetActive(false);
        for(int i = 0; i < componentsToDisable.Length; i++)
        {
            componentsToDisable[i].enabled = false;
        }
        Time.timeScale = 0f;
    }
    public void CloseMenu()
    {
        menuWindow.SetActive(false);
        menuButton.SetActive(true);
        for (int i = 0; i < componentsToDisable.Length; i++)
        {
            componentsToDisable[i].enabled = true;
        }
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
