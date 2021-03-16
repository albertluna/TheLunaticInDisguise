using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesBruce : MonoBehaviour
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



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {

        if (notes.br301)
        {

            MyText.text = "Has 2 children";
        }

        if (notes.br307)
        {

            MyText2.text = "Began drinking to overcome wife’s death";
        }

        if (notes.br300)
        {

            MyText3.text = "Alcohol made him more negligent";
        }

        if (notes.br302)
        {

            MyText4.text = "Heard people talking at Carol’s";
        }

        if (notes.br303)
        {

            MyText6.text = "Was at bar drinking";
        }

        if (notes.br323)
        {

            MyText5.text = "Lost custody because alcohol";
        }
        if (notes.br321)
        {

            MyText7.text = "Wife died at a car crash";
        }

        if (notes.br320)
        {

            MyText8.text = "Town’s cleaner";
        }

        if (notes.br322)
        {

            MyText9.text = "ruined";
        }

        if (notes.br354)
        {

            MyText10.text = "He controls drink, but fools town";
        }

        if (notes.br351)
        {

            MyText11.text = "Can’t stop drinking";
        }

        if (notes.br350)
        {

            MyText12.text = "Believes is incompetent to rise his children";
        }
            if (notes.br352)
            {

                MyText13.text = "Feels guilty for wife’s death";
            }

            if (notes.br353)
            {

                MyText14.text = "tornen l’Helena i el Damian al poble ";
            }

           

        
    }
}
