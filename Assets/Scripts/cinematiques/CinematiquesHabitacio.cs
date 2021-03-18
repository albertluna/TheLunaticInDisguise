using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CinematiquesHabitacio : MonoBehaviour
{
    public GameObject Robin;
    private Flowchart fc;
    private Animation anim;
    public GameObject canviEscena;
    private static bool primerDialeg;
    void Start()
    {
        fc = Robin.GetComponent<Flowchart>();
        anim = Robin.GetComponent<Animation>();
        Robin.GetComponent<MovimentSimple>().Mov = true;
        if (!primerDialeg) dialegIntroduccio();
    }

    public void moure() { Robin.GetComponent<MovimentSimple>().Mov = true; }
    public void noMoure() { Robin.GetComponent<MovimentSimple>().Mov = false; }

    public void anarADormir()
    {
        noMoure();
        anim.PlayQueued("anarDormirFase2i3");
    }

    public void despertarse()
    {
        anim.PlayQueued("Despertar-se");
        moure();
    }

    /*************************
     * 
     * FASE 1
     * 
     * **********************/
    //Primerdialeg de l'habitacio
    public void dialegIntroduccio()
    {
        primerDialeg = true;
        canviEscena.GetComponent<BoxCollider2D>().enabled = false;
        moure();
        fc.ExecuteBlock("iniciConv");
        GameObject.Find("canviFase").GetComponent<BoxCollider2D>().enabled = false;
    }

    public void dialegIntroduccio2()
    {
        // Execucio de l'animacio
        anim.Play("Dormir0");
    }

    public void dialegIntroduccio3()
    {
        //S'activa el canvi d'escena
        canviEscena.GetComponent<BoxCollider2D>().enabled = true;

        // Execucio de l'animacio
        anim.PlayQueued("Dormir 1");

    }
    public void dialegIntroduccio4()
    {
        anim.PlayQueued("Dormir 2");
    }

    /**********************
     * 
     * FASE 2
     * 
     * *******************/

    public void iniciFase2()
    {
        noMoure();
        Cinematiques.setPrimerDialegFase2();
        //animacio adormir-se i despertar-se
        Debug.Log("BONES2");
        //dialeg inicial
        fc.ExecuteBlock("iniciFase2");
        moure();
    }

    /*********************
     * 
     * FASE 3
     * 
     * ******************/
    public void iniciFase3()
    {
        noMoure();
        Cinematiques.setPrimerDialegFase3();
        //animacio adormir-se
        Debug.Log("BONES3");


        //dialeg inicial
        fc.ExecuteBlock("iniciFase3");

        //animacio aixecar-se
        moure();

    }

    public void cinematicaInicialFase()
    {
        Debug.Log("CINEMATICAINICIAL FASE" + SceneChange.fase);
        switch (SceneChange.fase)
        {
            case 2:
                iniciFase2();
                break;
            case 3:
                iniciFase3();
                break;
        }
    }
}
