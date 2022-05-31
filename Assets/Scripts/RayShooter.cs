using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();

        // lock mouse and hide mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
        
    void Update()
    {
        // respond to the left mouse button
        if (Input.GetKeyDown(KeyCode.E))
        {
            // use the center of the screen for our ray origin
            Vector3 point = new Vector3(cam.pixelWidth/2, cam.pixelHeight/2, 0);

            // create the ray at that position by using ScreenPointToRay()
            Ray ray = cam.ScreenPointToRay(point);

            RaycastHit hit;
            
            // get information from the raycast
            if (Physics.Raycast(ray, out hit))
            {
                // retrieve the object the ray hit
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                
                // check for the ReactiveTarget component on the object
                if (target != null)
                {
                    // call a method of the target that reacts to hit
                    target.ReactToHit();
                    
                    // display on console that target was hit
                    //Debug.Log("Target hit!");
                }                
            }
        }
    }
    
    private void OnGUI()
    {
        int size = 12;
        float posX = cam.pixelWidth / 2 - size / 4;
        float posY = cam.pixelHeight / 2 - size / 2;

        // display a "crosshair" on screen through GUI.Label()
        GUI.Label(new Rect(posX, posY, size, size), "+");
    }
}
