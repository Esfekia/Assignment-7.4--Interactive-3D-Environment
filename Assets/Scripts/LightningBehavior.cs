using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningBehavior : MonoBehaviour
{
    public AudioSource lightningSound;
    public AudioSource alienCurse;
    private GameManager gameManager;
    // OnTriggerEnter is called when the Collider other enters the trigger

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            gameObject.BroadcastMessage("LightningOn");
            lightningSound.Play();
            alienCurse.Play();
            gameManager.obj2done = true;
            Debug.Log("Obj2 done");

        }

    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.BroadcastMessage("LightningOff");
            lightningSound.Stop();
        }
    }

}
