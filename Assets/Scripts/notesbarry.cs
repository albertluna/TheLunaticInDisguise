using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class notesbarry : MonoBehaviour
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
        int notabarry1 = flowchart.GetIntegerVariable("Barry");
     

        if (notabarry1 == 102)
        {

            MyText.text = "Eleanor’s brother";
        }

        if (notabarry1 == 107)
        {

            MyText2.text = "Super rich";
        }

        if (notabarry1 == 101)
        {

            MyText3.text = "People think he’s miserable";
        }

        if (notabarry1 == 104)
        {

            MyText4.text = "Was out of town with friends";
        }

        if (notabarry1 == 122)
        {

            MyText6.text = "Mum’s ex";
        }

        if (notabarry1 == 105)
        {

            MyText5.text = "Was out of town with friends";
        }
        if (notabarry1 == 123)
        {

            MyText7.text = "orphan too young";
        }

        if (notabarry1 == 121)
        {

            MyText8.text = "Won the lottery";
        }

        if (notabarry1 == 120)
        {

            MyText9.text = "Owns a clothes factory";
        }

        if (notabarry1 == 125)
        {

            MyText10.text = "Nobody complains about his factory";
        }

        if (notabarry1 == 124)
        {

            MyText11.text = "Lonely guy";
        }

        if (notabarry1 == 156)
        {

            MyText12.text = "Can’t leave ‘cause mum";
        }
        if (notabarry1 == 155)
        {

            MyText13.text = "Has no friends";
        }

            if (notabarry1 == 153)
            {

                MyText14.text = "Still has a crush on mum";
            }

            if (notabarry1 == 151)
            {

                MyText15.text = "Reported Bruce to cops";
            }

            if (notabarry1 == 150)
            {

                MyText16.text = "Thinks Pamela is the masked";
            }

            if (notabarry1 == 154)
            {

                MyText17.text = "tornar amb els seus nebots";

            }
            if (notabarry1 == 999)
            {

                MyText18.text = "Blames Bruce Eleanor’s dead";
            }

        
    }
}
