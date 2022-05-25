using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBehavior : MonoBehaviour
{

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            gameObject.BroadcastMessage("LightningOn");
            
        }

    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.BroadcastMessage("LightningOff");
        }
    }

}
