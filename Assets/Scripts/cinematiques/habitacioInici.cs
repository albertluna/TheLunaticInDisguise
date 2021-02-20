using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class habitacioInici : MonoBehaviour
{
    private Flowchart Robin;
    private Animation anim;
    public GameObject canviEscena;
    private bool hasToPlay;
    void Start()
    {
        GameObject character = GameObject.Find("Robin");
        Robin = character.GetComponent<Flowchart>();
        anim = character.GetComponent<Animation>();
        canviEscena.GetComponent<BoxCollider2D>().isTrigger = false;
        hasToPlay = true;
        character.GetComponent<MovimentSimple>().Mov = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool play = (bool)Robin.GetBooleanVariable("finish");
        if (play && hasToPlay)
        {
            Debug.Log("PLAY NOW");
            anim.Play("Dormir0");
            hasToPlay = false;
            Robin.ExecuteBlock("Explicacio0");

        }
    }
    public void canTrigger()
    {
        canviEscena.GetComponent<BoxCollider2D>().isTrigger = true;
        anim.PlayQueued("Dormir 1");
        Robin.ExecuteBlock("Explicacio1");


    }
    public void explicacio1()
    {
        anim.PlayQueued("Dormir 2");

    }
}
