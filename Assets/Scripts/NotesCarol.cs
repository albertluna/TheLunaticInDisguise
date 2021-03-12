using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesCarol : MonoBehaviour
{
    public Flowchart flowchart;
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
    public TMP_Text MyText14;
    public TMP_Text MyText15;
    public TMP_Text MyText16;
    public TMP_Text MyText17;
    public TMP_Text MyText18;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int notabarry1 = flowchart.GetIntegerVariable("Carol");


        if (notabarry1 == 207)
        {

            MyText.text = "Eleanor’s brother";
        }

        if (notabarry1 == 211)
        {

            MyText2.text = "Super rich";
        }

        if (notabarry1 == 206)
        {

            MyText3.text = "People think he’s miserable";
        }

        if (notabarry1 == 201)
        {

            MyText4.text = "Was out of town with friends";
        }

        if (notabarry1 == 204)
        {

            MyText6.text = "Mum’s ex";
        }

        if (notabarry1 == 205)
        {

            MyText5.text = "Was out of town with friends";
        }
        if (notabarry1 == 208)
        {

            MyText7.text = "orphan too young";
        }

        if (notabarry1 == 999)
        {

            MyText8.text = "Payed her collection with legacy";
        }

        if (notabarry1 == 998)
        {

            MyText9.text = "Unable to reach her dreams";
        }

        if (notabarry1 == 220)
        {

            MyText10.text = "In a relation with Oliver’s sister";
        }

        if (notabarry1 == 221)
        {

            MyText11.text = "Complains about Barry’s factory";
        }

        if (notabarry1 == 222)
        {

            MyText12.text = "Pamela has looked after her since always";
        }
            if (notabarry1 == 223)
            {

                MyText13.text = "Wants to be the new mayor";
            }

            if (notabarry1 == 254)
            {

                MyText14.text = "Had it off with Oliver";
            }

            if (notabarry1 == 250)
            {

                MyText15.text = "Oliver has discovered their relation";
            }

            if (notabarry1 == 997)
            {

                MyText16.text = "Left the city because the lack of apportunities";
            }

            if (notabarry1 == 251)
            {

                MyText17.text = "Been at home all night";

            }
            if (notabarry1 == 253)
            {

                MyText18.text = " acabar juntes públicament";
            }

        
    }
}
