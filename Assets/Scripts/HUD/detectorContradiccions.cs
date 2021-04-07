using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorContradiccions : MonoBehaviour
{
    public detectobj detector1;
    public detectobj detector2;

    private int id1;
    private int id2;

    public bool contr1 = false;
    public bool contr2 = false;
    public bool contr3 = false;
    public bool contr4 = false;
    public bool contr5 = false;
    public bool contr6 = false;
    public bool contr7 = false;
    public bool contr8 = false;
    public bool contr9 = false;
    public bool contr10 = false;
    public bool contr11 = false;
    public bool contr12 = false;
    public bool contr13 = false;
    public bool contr14 = false;
    public bool contr15 = false;
    public bool contr16 = false;
    public bool contr17 = false;
    public bool contr18 = false;
    public bool contr19 = false;
    public bool contr20 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*id1 = detector1.idNota;
        id2 = detector2.idNota;
        esContradiccio();*/
    }

    public void esContradiccio()
    {
        id1 = detector1.idNota;
        id2 = detector2.idNota;

        if (idCoincidents(107, 101))
        {
            Debug.Log("ES UNA CONTRADICCIO");
        }

        if (idCoincidents(105, 108))
        {
            contr1 = true;
        }

        if (idCoincidents(208, 302))
        {
            contr2 = true;
        }

        if (idCoincidents(303, 413))
        {
            contr3 = true;
        }

        if (idCoincidents(501, 412))
        {
            contr4 = true;
        }

        if (idCoincidents(125, 424))
        {
            contr5 = true;
        }

        if (idCoincidents(420, 424))
        {
            contr6 = true;
        }

        if (idCoincidents(425, 521))
        {
            contr7 = true;

        }
        if (idCoincidents(523, 520))
        {
            contr8 = true;
        }

        if (idCoincidents(552, 553))
        {
            contr9 = true;
        }

        if (idCoincidents(550, 451))
        {
            contr10 = true;
        }

        if (idCoincidents(150, 551))
        {
            contr11 = true;
        }

        if (idCoincidents(251, 452))
        {
            contr12 = true;
        }

        if (idCoincidents(351, 354))
        {
            contr13 = true;
        }
    }

    private bool idCoincidents(int varA, int varB)
    {
        return (this.id1 == varA && id2 == varB || id1 == varB && id2 == varA);
    }

}