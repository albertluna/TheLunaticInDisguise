using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class NotesOliver : MonoBehaviour
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
    public TMP_Text MyText19;
    public TMP_Text MyText20;
    public TMP_Text MyText21;
    public TMP_Text MyText22;
    public TMP_Text MyText23;
    public TMP_Text MyText24;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int notabarry1 = flowchart.GetIntegerVariable("Oliver");


        if (notabarry1 == 416)
        {

            MyText.text = "Lidia’s son";
        }

        if (notabarry1 == 401)
        {

            MyText2.text = "Verdant’s Barman";
        }

        if (notabarry1 == 402)
        {

            MyText3.text = "Mayor";
        }

        if (notabarry1 == 415)
        {

            MyText4.text = "Married to Felicity";
        }

        if (notabarry1 == 409)
        {

            MyText6.text = "Two children(Connor and Mia)";
        }

        if (notabarry1 == 405)
        {

            MyText5.text = "Sexist";
        }
        if (notabarry1 == 414)
        {

            MyText7.text = "Sister’s wasn’t at home";
        }

        if (notabarry1 == 413)
        {

            MyText8.text = "Closed Verdant’s earlier";
        }

        if (notabarry1 == 412)
        {

            MyText9.text = "Her aunt never visits his mother Lidia";
        }

        if (notabarry1 == 403)
        {

            MyText10.text = "Thea’s in weelchair";
        }

        if (notabarry1 == 404)
        {

            MyText11.text = "Somebody wreck the Verdant’s";
        }

        if (notabarry1 == 408)
        {

            MyText12.text = "Barry has no friends";
        }
            if (notabarry1 == 410)
            {

                MyText13.text = "Bruce’s friend";
            }

            if (notabarry1 == 422)
            {

                MyText14.text = "Thea became paralytic few ago";
            }

            if (notabarry1 == 423)
            {

                MyText15.text = "Both siblings wanted the Verdant’s";
            }

            if (notabarry1 == 420)
            {

                MyText16.text = "Verdant’s close to bankruptcy";
            }

            if (notabarry1 == 421)
            {

                MyText17.text = "Homophobic";

            }
            if (notabarry1 == 424)
            {

                MyText18.text = "Verdant’s doing well economically";
            }
            if (notabarry1 == 425)
            {

                MyText19.text = "Barry found cow’s excrement at the sewer";
            }
            if (notabarry1 == 450)
            {

                MyText20.text = "Doesn’t love Felicity";
            }
            if (notabarry1 == 453)
            {

                MyText21.text = "Diverted públic funds to keep Verdant’s afloat";
            }
            if (notabarry1 == 451)
            {

                MyText22.text = "Pamela hates he doesn’t use her cow’s milk";
            }
            if (notabarry1 == 452)
            {

                MyText23.text = "Saw Carol pilled up";
            }
            if (notabarry1 == 999)
            {

                MyText24.text = "Carol nova alcaldessa reina legend la amo";
            }


        
    }
}
