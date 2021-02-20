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
        canviEscena.GetComponent<BoxCollider2D>().isTrigger = false;
        Robin.GetComponent<MovimentSimple>().Mov = true;
        if (!primerDialeg) dialegIntroduccio();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Primerdialeg de l'habitacio
    public void dialegIntroduccio()
    {
        primerDialeg = true;
        Robin.GetComponent<MovimentSimple>().Mov = false;
        fc.ExecuteBlock("iniciConv");
    }

    public void dialegIntroduccio2()
    {
        // Execucio de l'animacio
        anim.Play("Dormir0");
    }

    public void dialegIntroduccio3()
    {
        //S'activa el canvi d'escena
        canviEscena.GetComponent<BoxCollider2D>().isTrigger = true;

        // Execucio de l'animacio
        anim.PlayQueued("Dormir 1");

    }
    public void dialegIntroduccio4()
    {
        anim.PlayQueued("Dormir 2");
    }
}
