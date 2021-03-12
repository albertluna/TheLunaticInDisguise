using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesBruce : MonoBehaviour
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



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int notabarry1 = flowchart.GetIntegerVariable("Bruce");


        if (notabarry1 == 301)
        {

            MyText.text = "Has 2 children";
        }

        if (notabarry1 == 307)
        {

            MyText2.text = "Began drinking to overcome wife’s death";
        }

        if (notabarry1 == 300)
        {

            MyText3.text = "Alcohol made him more negligent";
        }

        if (notabarry1 == 302)
        {

            MyText4.text = "Heard people talking at Carol’s";
        }

        if (notabarry1 == 303)
        {

            MyText6.text = "Was at bar drinking";
        }

        if (notabarry1 == 323)
        {

            MyText5.text = "Lost custody because alcohol";
        }
        if (notabarry1 == 321)
        {

            MyText7.text = "Wife died at a car crash";
        }

        if (notabarry1 == 320)
        {

            MyText8.text = "Town’s cleaner";
        }

        if (notabarry1 == 322)
        {

            MyText9.text = "ruined";
        }

        if (notabarry1 == 354)
        {

            MyText10.text = "He controls drink, but fools town";
        }

        if (notabarry1 == 351)
        {

            MyText11.text = "Can’t stop drinking";
        }

        if (notabarry1 == 350)
        {

            MyText12.text = "Believes is incompetent to rise his children";
        }
            if (notabarry1 == 352)
            {

                MyText13.text = "Feels guilty for wife’s death";
            }

            if (notabarry1 == 353)
            {

                MyText14.text = "tornen l’Helena i el Damian al poble ";
            }

           

        
    }
}
