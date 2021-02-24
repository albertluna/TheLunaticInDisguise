using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Cinematiques : MonoBehaviour
{
    private Flowchart Helena;
    private static bool primerDialeg;
    public GameObject Robin;
    private Animation animCamera;
    private Animation animRobin;
    private AnimationEvent moureRobin;
    // Start is called before the first frame update
    void Start()
    {
        Helena = GameObject.Find("Helena").GetComponent<Flowchart>();
        Robin.GetComponent<MovimentSimple>().Mov = true;
        animCamera = GameObject.Find("Main Camera").GetComponent<Animation>();
        animRobin = Robin.GetComponent<Animation>();
        if (!primerDialeg) DialegIntroduccio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DialegIntroduccio()
    {
        //Prohibir moure el personatge
        Robin.GetComponent<MovimentSimple>().Mov = false;
        primerDialeg = true;
        //Començar la conversa
        Helena.ExecuteBlock("iniciConv");
    }

    void animacioInicial1()
    {
        animCamera.Play("cinematicaInicial");
    }

    void moureRobinAPosicio2()
    {
        Debug.Log("QUE FORT");
        animRobin.Play("cineInicialRobin");
        //seguir.GetComponent<Animation>().PlayQueued("cine2Robin");

    }

    void iniciarFugidaEmmascarat()
    {
        Debug.Log("BUENAS");
        Animation emmascarada = GameObject.Find("Emmascarada").GetComponent<Animation>();
        emmascarada.Play("fugidaEmmascarat2");

    }
    
}
