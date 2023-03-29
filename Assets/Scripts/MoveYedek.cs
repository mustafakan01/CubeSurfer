using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveYedek : MonoBehaviour
{
  
     [SerializeField]
    private float goForward;
     [SerializeField]
    private float turnSpeed;
    private float yatayeksen {get; set;} 

    void Start()
    {
        
    }

  
    void Update()
    {

        
        //yön tuþlarý ile kontrol
        float yatayeksen = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime ;
       this.transform.Translate(goForward * Time.deltaTime, yatayeksen, 0);
    }
}
