using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowHunterBehavior : MonoBehaviour
{
    private GameManager gameManager;
    public AudioSource shadowHunterKill;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.obj1done = true;
            shadowHunterKill.Play();

        }

    }


}
