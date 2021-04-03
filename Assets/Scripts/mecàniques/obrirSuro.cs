using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obrirSuro : MonoBehaviour
{
    public GameObject suro;
    public GameObject Robin;
    private MovimentSimple moviment;

    // Start is called before the first frame update
    void Start()
    {
        moviment = Robin.GetComponent<MovimentSimple>();
        suro.SetActive(false);

        //carregar les contradiccions
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            suro.SetActive(false);
            moviment.Mov = true;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            moviment.Mov = false;
            suro.SetActive(true);
        }
        //Es repren el moviment Mov a Cinematiques.nouInvestigat();
    }
}
