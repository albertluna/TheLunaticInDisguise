using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanviaSuro : MonoBehaviour
{
    // Start is called before the first frame update
    public contradiccioSuro[] suros;


    void Start()
    {
        //novesContradiccions();
        suros = GetComponentsInChildren<contradiccioSuro>();
    }

    public void novesContradiccions(int id)
    {
        foreach(contradiccioSuro contradiccions in suros)
        {
            if (id == contradiccions.idContradiccio)
            {
                contradiccions.activar();
            }
        }
    } 
    /*
    private void novesContradiccions()
    {
        if (contradiccions.contr1 == true)
        {
            entrat = true;
            cont1 = true;
            MyText.text = "Barry: Què va fer ahir a la nit?";
        }

        if (contradiccions.contr2 == true)
        {
            entrat2 = true;
            cont2 = true;
            MyText2.text = "    Carol: Amb qui estava ahir a la nit? ";
        }

        if (contradiccions.contr3 == true)
        {
            entrat3 = true;
            cont3 = true;
            MyText3.text = "Bruce: Va mentir sobre el què va fer";
        }

        if (contradiccions.contr4 == true)
        {
            entrat4 = true;
            cont4 = true;
            MyText4.text = "Pamela: on estava?";
        }
        if (cont1 == true)
        {
            MyText.text = "Barry: Què va fer ahir a la nit?";
        }
        if (cont2 == true)
        {
            MyText2.text = "    Carol: Amb qui estava ahir a la nit? ";
        }
        if (cont3 == true)
        {
            MyText3.text = "Bruce: Va mentir sobre el què va fer";
        }
        if (cont4 == true)
        {
            MyText4.text = "Pamela: on estava?";
        }
        if (cont5 == true)
        {
            MyText5.text = "Qui s'ha quixat de la fabrica";
        }
        if (cont6 == true)
        {
            MyText6.text = "Com esta el bar?";
        }
        if (cont7 == true)
        {
            MyText7.text = "Que ha pasat amb els fems de vaca?";
        }
        if (cont8 == true)
        {
            MyText8.text = "La Pamela ha tingut parella?";
        }
        if (cont9 == true)
        {
            MyText9.text = "la Pamela va escoltar a l'Oliver o va dormir?";
        }
        if (cont10 == true)
        {
            MyText10.text = "Pamela: Que ha pasat amb la llet?";
        }
        if (cont11 == true)
        {
            MyText11.text = "El problema de l'aigua es culpa de la Pamela o en Barry?";
        }
        if (cont12 == true)
        {
            MyText12.text = "La Carol va sortir de casa?";
        }
        if (cont13 == true)
        {
            MyText13.text = "En Bruce segueix bebent?";
        }
        /*if (contradiccions.cont5 == true)
        {
            MyText5.text = "Qui s'ha quixat de la fabrica";
        }
        if (contradiccions.cont6 == true)
        {
            MyText6.text = "Com esta el bar?";
        }
        if (contradiccions.cont7 == true)
        {
            MyText7.text = "Que ha pasat amb els fems de vaca?";
        }
        if (contradiccions.cont8 == true)
        {
            MyText8.text = "La Pamela ha tingut parella?";
        }
        if (contradiccions.cont9 == true)
        {
            MyText9.text = "la Pamela va escoltar a l'Oliver o va dormir?";
        }
        if (contradiccions.cont10 == true)
        {
            MyText10.text = "Pamela: Que ha pasat amb la llet?";
        }
        if (contradiccions.cont11 == true)
        {
            MyText11.text = "El problema de l'aigua es culpa de la Pamela o en Barry?";
        }
        if (contradiccions.cont12 == true)
        {
            MyText12.text = "La Carol va sortir de casa?";
        }
        if (contradiccions.cont13 == true)
        {
            MyText13.text = "En Bruce segueix bebent?";
        }*/    
    //}

}

