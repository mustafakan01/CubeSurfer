using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Topla")
        {
            Stack.instance.Pickdown(other.gameObject, true, "Untagged", false);
        }
    }

}
