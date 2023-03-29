using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{

    public static Stack instance;

    public float high;

    [SerializeField] private GameObject anaküp;

    [SerializeField] private float distanceBetween;
    [SerializeField] private Transform prevObject;
    [SerializeField] private Transform parent;

    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }


    void Start()
    {
        distanceBetween = prevObject.localScale.y;
    }

    void Update()
    {
        anaküp.transform.position = new Vector3(transform.position.x, high, transform.position.z);
        this.transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
    }
    public void highDecrease()
    {

        high--;

    }
    public void Pickdown(GameObject pickObject, bool needTag=false,string tag=null,bool down=true)
    {
        if (needTag)
        {
            pickObject.tag = tag;
        }
        high += 1;
        pickObject.transform.parent = parent;
        Vector3 despos = prevObject.localPosition;
        despos.y += down ? distanceBetween : -distanceBetween;
        pickObject.transform.localPosition = despos;
        prevObject = pickObject.transform;
    }
   
}
