using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public GameObject parent;
    public int i;

    public void Start()
    {
        for (i = 0; i< 4; i++)
        {
            parent.transform.GetChild(i).gameObject.SetActive(false);
        }
        
    }
    public void LightningOn()
    {
        Debug.Log("In danger zone.");
        for (i = 0; i < 4; i++)
        {
            parent.transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    public void LightningOff()
    {
        Debug.Log("Out of danger zone.");
        for (i = 0; i < 4; i++)
        {
            parent.transform.GetChild(i).gameObject.SetActive(false);
        }
    }


}