using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Piker : MonoBehaviour
{
    
    public static Piker instance; 
    [SerializeField] private GameObject maincube;

    public GameObject gamefinish;

    public float high;

    private bool hasgathered;

    private float index;
    public Vector3 distance { get; private set; }
    public static bool isPaused { get; private set; }
    public Rigidbody r_Rigidbody { private get;  set; }



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        maincube.transform.position = new Vector3(transform.position.x, high, transform.position.z);
        this.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);    
    }

    public void highDecrease()
    {
         
        //high--;
         
    }
    public bool hasGathered()
    {
        return hasgathered;
    }
    
    public void Gathered()
    {
        hasgathered = true;
    }
    public void IndexSet(float index)
    {
        this.index = index;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Topla")
        {       
            high += 1;
            other.gameObject.GetComponent<Cube>().Gathered();
            other.gameObject.GetComponent<Cube>().IndexSet(high);
            other.gameObject.transform.parent = maincube.transform;
            r_Rigidbody = other.gameObject.AddComponent<Rigidbody>();
            r_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;          

        }
        else if (other.gameObject.tag=="Finish")
        {

            gamefinish.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
            LevelManager.instance.SaveGame();
           // LevelManager.instance.CreatetLevel();
            LevelManager.instance.DestroyLevel();
            

        }
        
    }
    
}
