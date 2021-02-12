using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class habitacioInici : MonoBehaviour
{
    private Flowchart fc;
    private Animation anim;
    public GameObject bc;
    private bool hasToPlay;
    // Start is called before the first frame update
    void Start()
    {
        fc = GetComponent<Flowchart>();
        anim = GetComponent<Animation>();
        bc.GetComponent<BoxCollider2D>().isTrigger = false;
        hasToPlay = true;
        GetComponent<MovimentSimple>().Mov = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool play = (bool)fc.GetBooleanVariable("finish");
        if (play && hasToPlay)
        {
            Debug.Log("PLAY NOW");
            anim.Play("Dormir0");
            hasToPlay = false;
            fc.ExecuteBlock("Explicacio0");

        }
    }
    public void canTrigger()
    {
        bc.GetComponent<BoxCollider2D>().isTrigger = true;
        anim.PlayQueued("Dormir 1");
        fc.ExecuteBlock("Explicacio1");


    }
    public void explicacio1()
    {
        anim.PlayQueued("Dormir 2");

    }
}
