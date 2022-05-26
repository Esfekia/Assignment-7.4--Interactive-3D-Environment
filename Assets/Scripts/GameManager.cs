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

    // Start is called before the first frame update
    void Start()
    {
        objective1.text = "Objective 1: Check Prison 1.";
        objective2.text = "Objective 1: Check Prison 2.";
        objective3.text = "Objective 1: Check Prison 3.";
        objective4.text = "Objective 4: Obtain any clues/evidence.";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
