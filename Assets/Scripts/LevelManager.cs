using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;


    public int i;

    GameObject createtlevel;

    public List<GameObject> levels=new List<GameObject>();
        
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    void Start()
    {    

        CreatetLevel();
        if (PlayerPrefs.HasKey("i"))
        {
            i= PlayerPrefs.GetInt("i");
            Debug.Log("Level " + i + " Kaydedildi");
            
        }
    }

    void Update()
    {
        
    }
    
    public void SaveGame()
    {
        i++;
        PlayerPrefs.SetInt("i", i);     
        Debug.Log("Kaydedildi"+i);      
               
    }

    public void CreatetLevel()
    {
        createtlevel = Instantiate(levels[PlayerPrefs.GetInt("i")%levels.Count], transform.position, transform.rotation);
        Debug.Log("çalýþtým");
        createtlevel.transform.parent = transform;
        Debug.Log("valla çalýþtým");

    } 

    public void DestroyLevel()
    {

        createtlevel.transform.parent = null;
        Destroy(createtlevel);
        SceneManager.LoadScene(0);

    }

}
