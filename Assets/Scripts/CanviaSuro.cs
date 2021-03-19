using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanviaSuro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prinotes;
    public scriptact contradiccions;
    public TMP_Text MyText;
    public TMP_Text MyText2;
    public TMP_Text MyText3;
    public TMP_Text MyText4;
    public TMP_Text MyText5;
    public TMP_Text MyText6;
    public TMP_Text MyText7;
    public TMP_Text MyText8;
    public TMP_Text MyText9;
    public TMP_Text MyText10;
    public TMP_Text MyText11;
    public TMP_Text MyText12;
    public TMP_Text MyText13;

    public bool entrat = false;
    public bool entrat2 = false;
    public bool entrat3 = false;
    public bool entrat4 = false;
    public bool cont1 = false;
    public bool cont2 = false;
    public bool cont3 = false;
    public bool cont4 = false;
    public bool cont5 = false;
    public bool cont6 = false;
    public bool cont7 = false;
    public bool cont8 = false;
    public bool cont9 = false;
    public bool cont10 = false;
    public bool cont11 = false;
    public bool cont12 = false;
    public bool cont13 = false;


    void Start()
    {
        contradiccions = prinotes.GetComponent<scriptact>();
    }

    // Update is called once per frame
    void Update()
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
        if(cont1 == true)
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

    }
}

