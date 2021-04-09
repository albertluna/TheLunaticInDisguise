﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorContradiccions : MonoBehaviour
{
    public detectobj detector1;
    public detectobj detector2;

    private int id1;
    private int id2;

    public CanviaSuro cs;


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


    public void esContradiccio()
    {
        id1 = detector1.idNota;
        id2 = detector2.idNota;

        if (idCoincidents(102, 107))
        {
            setContradiccio(1);
        }

        if (idCoincidents(208, 302))
        {
            setContradiccio(2);
        }

        if (idCoincidents(303, 413))
        {
            setContradiccio(3);
        }

        if (idCoincidents(501, 412))
        {
            setContradiccio(4);
        }

        if (idCoincidents(125, 424))
        {
            setContradiccio(5);
        }

        if (idCoincidents(420, 424))
        {
            setContradiccio(6);
        }

        if (idCoincidents(425, 521))
        {
            setContradiccio(7);

        }
        if (idCoincidents(523, 520))
        {
            setContradiccio(8);
        }

        if (idCoincidents(552, 553))
        {
            setContradiccio(9);
        }

        if (idCoincidents(550, 451))
        {
            setContradiccio(10);
        }

        if (idCoincidents(150, 551))
        {
            setContradiccio(11);
        }

        if (idCoincidents(251, 452))
        {
            setContradiccio(12);
        }

        if (idCoincidents(351, 354))
        {
            setContradiccio(13);
        }
    }

    private bool idCoincidents(int varA, int varB)
    {
        return (this.id1 == varA && id2 == varB || id1 == varB && id2 == varA);
    }

    private void setContradiccio(int id)
    {
        cs.novesContradiccions(id);
    }

}