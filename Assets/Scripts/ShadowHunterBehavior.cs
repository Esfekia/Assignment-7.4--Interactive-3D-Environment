using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowHunterBehavior : MonoBehaviour
{
    
    public AudioSource shadowHunterKill;
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            shadowHunterKill.Play();

        }

    }


}
