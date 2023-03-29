using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject gameMenu;
    private static bool isPaused;

    private void Start()
    {
        Time.timeScale = 0;
        isPaused = true;
    }
    public void PlayButon()
    {
        gameMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    
    
}
