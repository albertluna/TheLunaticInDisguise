using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Reflection;
using System;
using UnityEngine.UI;
using TMPro;
public class Suro : MonoBehaviour
{
    Flowchart flowchart;
 
    public TMP_Text MyText;
    // Start is called before the first frame update
    void Start()
    {
        MyText.text = "pistes aqui";
        bool OliverHero = false;
        bool OliverDrunk = false;
        bool PistaBruceBlame = false;
        bool PistaBruceKid = false;
        bool PistaBruceDrink = false;

    }



    // Update is called once per frame
    void Update()
    {
       

/*         bool OliverHerop = (bool)flowchart.GetBooleanVariable("OliverHero");

        bool OliverDrunkp = (bool)flowchart.GetBooleanVariable("OliverDrunk");
        bool PistaBruceBlamep = (bool)flowchart.GetBooleanVariable("PistaBruceBlamep");
        bool PistaBruceKidp = (bool)flowchart.GetBooleanVariable("PistaBruceKid");
        bool PistaBruceDrinkp = (bool)flowchart.GetBooleanVariable("PistaBruceDrinkp");
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (OliverHerop == true)
            {
                if (OliverDrunkp == true)
                {

                    MyText.text = "Oliver esta mentint respecte les seves accions";
                }
            }

        }

        */

    }
}
