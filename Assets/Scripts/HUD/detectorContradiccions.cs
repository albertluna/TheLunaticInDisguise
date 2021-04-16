using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorContradiccions : MonoBehaviour
{
    public detectobj detector1;
    public detectobj detector2;

    private int id1;
    private int id2;

    public CanviaSuro cs;


    public void esContradiccio()
    {
        id1 = detector1.idNota;
        id2 = detector2.idNota;

        if (idCoincidents(105, 108))
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
        bool coincidents = (this.id1 == varA && id2 == varB || id1 == varB && id2 == varA);
        detector1.novaContradiccio(coincidents);
        detector2.novaContradiccio(coincidents);

        return coincidents;
    }

    private void setContradiccio(int id)
    {
        cs.novesContradiccions(id);
    }

}