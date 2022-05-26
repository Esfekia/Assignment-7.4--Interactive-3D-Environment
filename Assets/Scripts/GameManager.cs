using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI objective1;
    public TextMeshProUGUI objective2;
    public TextMeshProUGUI objective3;
    public TextMeshProUGUI objective4;
    public TextMeshProUGUI gameOver;
    public bool obj1done = false;
    public bool obj2done = false;
    public bool obj3done = false;
    public bool obj4done = false;


    // Start is called before the first frame update
    void Start()
    {
        objective1.text = "Objective 1: Check Prison 1.";
        objective2.text = "Objective 2: Check Prison 2.";
        objective3.text = "Objective 3: Check Prison 3.";
        objective4.text = "Objective 4: Obtain any clues/evidence.";
        gameOver.text = " ";

    }

    // Update is called once per frame
    void Update()
    {
        if (obj1done)
        {
            objective1.text = "Objective 1: Completed.";
        }
        if (obj2done)
        {
            objective2.text = "Objective 2: Completed.";
        }
        if (obj3done)
        {
            objective3.text = "Objective 3: Completed.";
        }
        if (obj4done)
        {
            objective4.text = "Objective 4: Mysterius Object Secured.";
        }
        if (obj1done && obj2done && obj3done && obj4done)
        {
            gameOver.text = "LEVEL COMPLETE";
        }
    }
}
