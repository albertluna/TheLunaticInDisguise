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

    private int notaAntiga = -1;
  
 
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int notabarry1 = flowchart.GetIntegerVariable("Barry");
        Debug.Log("NOTA ANTINFGA = " + notaAntiga + ". NOTA NOVA = " + notabarry1);

        if(notabarry1 != notaAntiga)
        {
            setText(notabarry1);
            notaAntiga = notabarry1;
        }
    }

    private void setText(int id)
    {
        switch(id)
        {
            case 102:
                MyText.text = "Eleanor’s brother";
                break;
            case 107:
                Debug.Log("TIU");
                MyText2.text = "Super rich";
                break;
            case 101:
                MyText3.text = "People think he’s miserable";
                break;
            case 105:
                Debug.Log("HOLAAAA");
                MyText4.text = "Was out of town with friends";
                break;
            case 122:
                MyText5.text = "Mum’s ex";
                break;
            case 104:
                MyText6.text = "Hates Bruce";
                break;
            case 123:
                MyText7.text = "got orphan too young";
                break;
            case 121:
                MyText8.text = "Won the lottery";
                break;
            case 120:
                MyText9.text = "Owns a clothes factory";
                break;
            case 125:
                MyText10.text = "Nobody complains about his factory";
                break;
            case 124:
                MyText11.text = "Lonely guy";
                break;
            case 156:
                MyText12.text = "Can’t leave town ‘cause mum";
                break;
            case 155:
                MyText13.text = "Has no friends";
                break;
            case 153:
                MyText14.text = "Still has a crush on mum";
                break;
            case 151:
                MyText15.text = "Reported Bruce to cops";
                break;
            case 150:
                MyText16.text = "Thinks Pamela is the masked";
                break;
            case 999:
                MyText18.text = "Blames Bruce Eleanor’s dead";
                break;


        }
    }
}
