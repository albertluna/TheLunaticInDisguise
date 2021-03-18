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

            MyText2.text = "Hates to be bothered by people";
        }

        if (notes.pam506)
        {

            MyText3.text = "Prefers loneliness";
        }

        if (notes.pam501)
        {

            MyText4.text = "Was taking care of her sister Lidia last night";
        }

        if (notes.pam503)
        {

            MyText6.text = "Loves kids";
        }

        if (notes.pam504)
        {

            MyText5.text = "Lina ate her vegetables";
        }
        if (notes.pam502)
        {

            MyText7.text = "Goes to sleep at 9pm to wake at 5am";
        }

        if (notes.pam523)
        {

            MyText8.text = "Never been in a relationship";
        }

        if (notes.pam524)
        {

            MyText9.text = "Works at the farm everyday";
        }

        if (notes.pam520)
        {

            MyText10.text = "Confessed she was pregnant once";
        }

        if (notes.pam521)
        {

            MyText11.text = "Hasn’t noticed any feces gone";
        }

        if (notes.pam522)
        {

            MyText12.text = "Water polluted because of Barry’s factory";
        }
        if (notes.pam552)
        {

            MyText13.text = "Heard Oliver screaming at Carol’s house";
        }

        if (notes.pam553)
        {

            MyText14.text = "Was sleeping until now";
        }

        if (notes.pam550)
        {

            MyText15.text = "Went to sleep early to milk her cows and feed the town";
        }

        if (notes.pam551)
        {

            MyText16.text = "Thinks Barry is the lunatic";
        }
    }
}
