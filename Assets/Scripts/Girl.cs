using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    Animator anim;


    public int life = 1;
     void Start()
    {
        anim = GetComponent<Animator>();
    
    }

    void Update()
    {
        if (life != 1)
        {
            anim.SetInteger("life", 0);
           
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Plane")
        {
            Time.timeScale = 0;
        }
    }
}
