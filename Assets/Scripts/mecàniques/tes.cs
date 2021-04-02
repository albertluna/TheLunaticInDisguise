using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Reflection;
using System;

public class tes : MonoBehaviour
{
  
    Flowchart flowchart;
    private MovimentSimple moviment;
    private bool started;

    // Start is called before the first frame update
    void Start()
    {
        moviment = GameObject.Find("Robin").GetComponent<MovimentSimple>();
        //moviment = FindObjectOfType<MovimentSimple>();
        flowchart = GetComponent<Flowchart>();
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter)) && !flowchart.HasExecutingBlocks())
        {
            moviment.Mov = false;
            flowchart.ExecuteBlock("iniciConv");
            started = true;
        }
        //Es repren el moviment Mov a Cinematiques.nouInvestigat();
    }

}
