using System.Collections;
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
    public GameObject suro;
    public GameObject botons;
    public bool HUD_activable;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        newScene();
        actualitzaNotes();
        suro.SetActive(false);
        //no desactivar-lo, moure'l del centre
        botons.SetActive(false);
    }

    public void newScene()
    {
        GetComponent<parles>().newScene();
        Robin = GameObject.Find("Robin").GetComponent<MovimentSimple>();
    }

    public void activarBotoHud()
    {
        botons.SetActive(true);
        HUD_activable = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            actualitzaNotes();
        }
    }

    public void actualitzaNotes()
    {
        if (HUD_activable)
        {
            setNotes(canvi);
            Robin.notesObertes = canvi;
            canvi = !canvi;
        }
    }

    public void activarSuro(bool estat)
    {
        if(HUD_activable) suro.SetActive(estat);
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
