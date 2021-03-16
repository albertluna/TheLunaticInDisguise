using Fungus;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class notesbarry : MonoBehaviour
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

            if (notes.ba102) {
                MyText.text = "Eleanor’s brother";
                }
            if (notes.ba108)
            {
                    MyText6.text = "Barry has no friends";
                }
            if (notes.ba107) {
                MyText2.text = "Super rich";
                }
            if (notes.ba101) {
                MyText3.text = "People think he’s miserable";
                }
            if (notes.ba105) {
                MyText4.text = "Was out of town with friends";
                }
            if (notes.ba122) {
                MyText5.text = "Mum’s ex";
                }

            /*if (notes.ba104) {
                MyText6.text = "Hates Bruce";
                }*/
            if (notes.ba123) {
                MyText7.text = "got orphan too young";
                }
            if (notes.ba121) {
                MyText8.text = "Won the lottery";
                }
            if (notes.ba120) {
                MyText9.text = "Owns a clothes factory";
                }
            if (notes.ba125) {
                MyText10.text = "Nobody complains about his factory";
                }
            if (notes.ba124) {
                MyText11.text = "Lonely guy";
                }
            if (notes.ba156) {
                MyText12.text = "Can’t leave town ‘cause mum";
                }
            if (notes.ba155) {
                MyText13.text = "Has no friends";
                }
            if (notes.ba153) {
                MyText14.text = "Still has a crush on mum";
                }
            if (notes.ba151) {
                MyText15.text = "Reported Bruce to cops";
                }
            if (notes.ba150) {
                MyText16.text = "Thinks Pamela is the masked";
                }
/*            if (notes.ba999) {
                MyText18.text = "Blames Bruce Eleanor’s dead";
                }*/
    }
}
