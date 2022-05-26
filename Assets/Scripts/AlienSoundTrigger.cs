using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSoundTrigger : MonoBehaviour
{
    public AudioSource alienSound;
    public AudioSource alienKillSound;
    private GameManager gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            alienSound.Play();
            gameManager.obj2done = true;
            
        }

    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            alienKillSound.Play();
        }
    }

}
