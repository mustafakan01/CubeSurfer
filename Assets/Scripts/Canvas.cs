using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour
{

    public void ResButon()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
   
}
