using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesPamela : MonoBehaviour
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



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int notabarry1 = flowchart.GetIntegerVariable("Pamela");


        if (notabarry1 == 999)
        {

            MyText.text = "Runs the farm";
        }

        if (notabarry1 == 505)
        {

            MyText2.text = "Hates to be bothered by villagers";
        }

        if (notabarry1 == 506)
        {

            MyText3.text = "Prefers loneliness";
        }

        if (notabarry1 == 501)
        {

            MyText4.text = "Was taking care of her sister Lidia";
        }

        if (notabarry1 == 503)
        {

            MyText6.text = "Loves kids";
        }

        if (notabarry1 == 504)
        {

            MyText5.text = "Turtle ate her vegetable garden";
        }
        if (notabarry1 == 502)
        {

            MyText7.text = "Goes to sleep at 9pm and wakes at 5am";
        }

        if (notabarry1 == 523)
        {

            MyText8.text = "Never been in a relation";
        }

        if (notabarry1 == 524)
        {

            MyText9.text = "Work at the farm everyday";
        }

        if (notabarry1 == 520)
        {

            MyText10.text = "Confessed she was pregnant once";
        }

        if (notabarry1 == 521)
        {

            MyText11.text = "Has not seen any excrement robbery";
        }

        if (notabarry1 == 522)
        {

            MyText12.text = "Has found water polluted because Barry’s factory";
        }
            if (notabarry1 == 552)
            {

                MyText13.text = "Heard Oliver screaming from Carol’s house";
            }

            if (notabarry1 == 553)
            {

                MyText14.text = "Been sleeping ‘till fire";
            }

            if (notabarry1 == 550)
            {

                MyText15.text = "Went to sleep to milk her cows and feed town";
            }

            if (notabarry1 == 551)
            {

                MyText16.text = "Think Barry is the masked”";
            }


        
    }
}
