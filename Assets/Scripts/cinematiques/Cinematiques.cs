using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Cinematiques : MonoBehaviour
{
    private Flowchart fc;
    private static bool primerDialeg;
    public static bool primerDialeg3;
    public GameObject Robin;
    public GameObject Narrativa;
    private Animation animCamera;
    private Animation animRobin;
    private AnimationEvent moureRobin;

    // Start is called before the first frame update
    void Start()
    {
        //Helena = GameObject.Find("Helena").GetComponent<Flowchart>();
        fc = Narrativa.GetComponent<Flowchart>();
        Robin.GetComponent<MovimentSimple>().Mov = true;
        animCamera = GameObject.Find("Main Camera").GetComponent<Animation>();
        animRobin = Robin.GetComponent<Animation>();
        if (!primerDialeg) DialegIntroduccio();
        if (primerDialeg3) iniciFase3Carrer();
    }

    void DialegIntroduccio()
    {
        //Prohibir moure el personatge
        Robin.GetComponent<MovimentSimple>().Mov = false;
        primerDialeg = true;
        //Començar la conversa
        fc.ExecuteBlock("iniciConv");
    }

    void animacioInicial1()
    {
        animCamera.Play("cinematicaInicial");
    }

    void moureRobinAPosicio2()
    {
        animRobin.Play("cineInicialRobin");
        //seguir.GetComponent<Animation>().PlayQueued("cine2Robin");

    }

    void iniciarFugidaEmmascarat()
    {
        Animation emmascarada = GameObject.Find("Emmascarada").GetComponent<Animation>();
        emmascarada.Play("fugidaEmmascarat2");
    }

    /*****************************
     * 
     * FASE 3
     * 
     * **************************/

    public static void setPrimerDialegFase3() { primerDialeg3 = true; }

    void iniciFase3Carrer()
    {
        primerDialeg3 = false;
        fc.ExecuteBlock("foguera");
    }


}