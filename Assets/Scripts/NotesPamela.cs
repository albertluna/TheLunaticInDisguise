using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesPamela : MonoBehaviour
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



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

        /*if ( == 999)
        {

            MyText.text = "Runs the farm";
        }
        */

        if (notes.pam505)
        {

            MyText2.text = "Hates to be bothered by villagers";
        }

        if (notes.pam506)
        {

            MyText3.text = "Prefers loneliness";
        }

        if (notes.pam501)
        {

            MyText4.text = "Was taking care of her sister Lidia";
        }

        if (notes.pam503)
        {

            MyText6.text = "Loves kids";
        }

        if (notes.pam504)
        {

            MyText5.text = "Turtle ate her vegetable garden";
        }
        if (notes.pam502)
        {

            MyText7.text = "Goes to sleep at 9pm and wakes at 5am";
        }

        if (notes.pam523)
        {

            MyText8.text = "Never been in a relation";
        }

        if (notes.pam524)
        {

            MyText9.text = "Work at the farm everyday";
        }

        if (notes.pam520)
        {

            MyText10.text = "Confessed she was pregnant once";
        }

        if (notes.pam521)
        {

            MyText11.text = "Has not seen any excrement robbery";
        }

        if (notes.pam522)
        {

            MyText12.text = "Has found water polluted because Barry’s factory";
        }
        if (notes.pam552)
        {

            MyText13.text = "Heard Oliver screaming from Carol’s house";
        }

        if (notes.pam553)
        {

            MyText14.text = "Been sleeping ‘till fire";
        }

        if (notes.pam550)
        {

            MyText15.text = "Went to sleep to milk her cows and feed town";
        }

        if (notes.pam551)
        {

            MyText16.text = "Thinks Barry is the masked";
        }
    }
}
