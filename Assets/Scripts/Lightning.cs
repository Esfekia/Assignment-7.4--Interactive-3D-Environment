using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public void LightningOn()
    {
        Debug.Log("In danger zone.");
        gameObject.SetActive(true);
    }
    

}