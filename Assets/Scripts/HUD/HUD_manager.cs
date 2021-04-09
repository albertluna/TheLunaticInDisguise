﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_manager : MonoBehaviour
{
    private bool canvi = false;

    public Canvas canvas1;
    public Canvas canvas2;
    public Canvas canvas3;
    public Canvas canvas4;
    public Canvas canvas5;
    private MovimentSimple Robin;
    public Canvas blaus;
    public CanviaSuro suro;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        //this.gameObject.SetActive(false);
        newScene();
        //setNotes(false);
        
    }

    public void newScene()
    {
        GetComponent<parles>().newScene();
        Robin = GameObject.Find("Robin").GetComponent<MovimentSimple>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            setNotes(canvi);
            Robin.notesObertes = canvi;
            canvi = !canvi;
        }
    }

    //Funcio que activa o desactiva les notes del Barry
    public void setNotes(bool estat)
    {
        blaus.gameObject.SetActive(estat);
        canvas1.gameObject.SetActive(estat);
        canvas2.gameObject.SetActive(false);
        canvas3.gameObject.SetActive(false);
        canvas4.gameObject.SetActive(false);
        canvas5.gameObject.SetActive(false);
    }
}