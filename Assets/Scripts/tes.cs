using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Reflection;
using System;

public class tes : MonoBehaviour
{
  
    Flowchart flowchart;
    int collisioni;
    public MovimentSimple moviment;
    public bool final;

    // Start is called before the first frame update
    void Start()
    {
        moviment = GameObject.Find("Robin").GetComponent<MovimentSimple>();
        //moviment = FindObjectOfType<MovimentSimple>();
        flowchart = GetComponent<Flowchart>();
        final = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Condicio per començar el dialeg amb el personatge
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter)) && collisioni == 1 && !flowchart.HasExecutingBlocks())
        {
            moviment.Mov = false;
            collisioni = 0;
            flowchart.ExecuteBlock("iniciConv");
        }
        if (final)
        {
            moviment.Mov = true;
        } else
        {
            final = (bool)flowchart.GetBooleanVariable("finish");
        }

    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        collisioni = 1;
        Debug.Log("enter");
    }

    private void OnTriggerExit2D(UnityEngine.Collider2D other)
    {
        collisioni = 0;
        Debug.Log("exit");
    }
}
