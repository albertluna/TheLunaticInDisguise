using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesCarol : MonoBehaviour
{
    public parles notes;
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

        
        if (notes.car207)
        {

            MyText.text = "Studied cinema to direct superherois films";
        }

        if (notes.car211)
        {

            MyText2.text = "Super rich";
        }

        if (notes.car206)
        {

            MyText3.text = "Superheroe's nerd";
        }

        if (notes.car201)
        {

            MyText4.text = "Has a cat";
        }

        if (notes.car204)
        {

            MyText6.text = "Vegan";
        }

        if (notes.car205)
        {
            MyText5.text = "Pamela's friend";
        }
        if (notes.car208)
        {

            MyText7.text = "Was alone last night";
        }

        /*if (notes.car999)
        {

            MyText8.text = "Payed her collection with legacy";
        }
        
        if (notes.car998)
        {

            MyText9.text = "Unable to reach her dreams";
        }*/

        if (notes.car220)
        {

            MyText10.text = "In a relationship with Oliver’s sister";
        }

        if (notes.car221)
        {

            MyText11.text = "Complains about Barry’s factory";
        }

        if (notes.car222)
        {

            MyText12.text = "Pamela has looked after her since always";
        }
            if (notes.car223)
            {

                MyText13.text = "Wants to be the new mayor";
            }

            if (notes.car254)
            {

                MyText14.text = "Had it off with Oliver";
            }

            if (notes.car250)
            {

                MyText15.text = "Oliver has discovered their relation";
            }
            /*
            if (notes.car997)
            {

                MyText16.text = "Left the city because the lack of apportunities";
            }
            */
            if (notes.car251)
            {

                MyText17.text = "Been at home all night";

            }
            if (notes.car253)
            {

                MyText18.text = " acabar juntes públicament";
            }

        
    }
}
