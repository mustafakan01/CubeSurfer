using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    public GameObject center;
      
    public Girl girl;

    public GameObject gameOver;

    public void ResButon()
    {
        SceneManager.LoadScene(0);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag=="Char")
        {
            gameOver.SetActive(true);
            center.GetComponent<Move>().enabled = false;
            girl.GetComponent<Girl>().life = 0;
                    
        }    
    }
}
