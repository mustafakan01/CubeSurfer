using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public static Cube cube;

    private bool hasgathered;

    private float index ;

    public Piker piker { get; set; }
  
    

 

    void Start()
    {
        hasgathered = false;
    }

    void Update()
    {
       
        

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
        if (other.gameObject.tag == "Obstacle")
        {
            
            transform.parent = null;
            GetComponent<Cube>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

              
        }

        if (other.gameObject.tag=="Piker")
        {


            if (hasgathered == true)
            {
                if (transform.parent != null)
                {
                    transform.localPosition = new Vector3(0, -index, 0);

                }
            }
        }  
               
    }

}
