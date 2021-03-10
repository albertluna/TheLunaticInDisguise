using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Cinematiques : MonoBehaviour
{
    private Flowchart fc;
    private static bool primerDialeg;
    private static bool primerDialeg2;
    private static bool primerDialeg3;
    private static bool poli;
    public GameObject Robin;
    public GameObject Narrativa;
    private Animation animCamera;
    private Animation animRobin;
    private AnimationEvent moureRobin;
    private static int sospitososInvestigats = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Helena = GameObject.Find("Helena").GetComponent<Flowchart>();
        fc = Narrativa.GetComponent<Flowchart>();
        Robin.GetComponent<MovimentSimple>().Mov = true;
        animCamera = GameObject.Find("Main Camera").GetComponent<Animation>();
        animRobin = Robin.GetComponent<Animation>();
        if (!primerDialeg) DialegIntroduccio();
        if (primerDialeg2) iniciFase2Carrer();
        if (primerDialeg3) iniciFase3Carrer();
        if (poli) animacioPoli();
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
    }

    void moureRobinAPorta()
    {
        animRobin.Play("cineRobinAPorta");
    }

    void iniciarFugidaEmmascarat()
    {
        Animation emmascarada = GameObject.Find("Emmascarada").GetComponent<Animation>();
        emmascarada.Play("fugidaEmmascarat2");
    }

    void instruccioInicial()
    {
        if (sospitososInvestigats == 1 && SceneChange.fase==1)// &&fase1
        {
            fc.ExecuteBlock("instruccioInicial");
        }
    }

    /*****************************
     * 
     * FASE 2
     * 
     * **************************/

    public static void setPrimerDialegFase2() { primerDialeg2 = true; }

    void iniciFase2Carrer()
    {
        primerDialeg3 = false;
        sospitososInvestigats = 0;

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
        sospitososInvestigats = 0;
        fc.ExecuteBlock("foguera");
    }

    void animacioPoli()
    {
        poli = true;
        Narrativa.GetComponent<Animation>().PlayQueued("Poli");
    }


    /*****************************
     * 
     * GLOBAL
     * 
     * **************************/

    void nouInvestigat()
    {
        sospitososInvestigats++;
        Robin.GetComponent<MovimentSimple>().Mov = true;
        instruccioInicial();
        if (sospitososInvestigats == 5)
        {
            fc.ExecuteBlock("totsInvestigats");
        }
    }

}