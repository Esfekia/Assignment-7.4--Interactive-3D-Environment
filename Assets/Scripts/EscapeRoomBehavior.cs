using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeRoomBehavior : MonoBehaviour
{
    private GameManager gameManager;   
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.obj3done = true;
            

        }

    }


}
