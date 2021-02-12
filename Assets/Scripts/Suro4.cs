using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Reflection;
using System;
using UnityEngine.UI;
using TMPro;
public class Suro4 : MonoBehaviour
{
    Flowchart flowchart;

    public TMP_Text MyText;
    // Start is called before the first frame update
    void Start()
    {

        bool OliverHero = false;
        bool OliverDrunk = false;
        bool PistaBruceBlame = false;
        bool PistaBruceKid = false;
        bool PistaBruceDrink = false;

    }



    // Update is called once per frame
    void Update()
    {


        bool OliverHerop = (bool)flowchart.GetBooleanVariable("OliverHero");

        bool OliverDrunkp = (bool)flowchart.GetBooleanVariable("OliverDrunk");
        bool PistaBruceBlamep = (bool)flowchart.GetBooleanVariable("PistaBruceBlamep");
        bool PistaBruceKidp = (bool)flowchart.GetBooleanVariable("PistaBruceKid");
        bool PistaBruceDrinkp = (bool)flowchart.GetBooleanVariable("PistaBruceDrinkp");
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (PistaBruceKidp == true)
            {
                if (OliverHerop == true)
                {

                    MyText.text = "Oliver o Bruce tenen explcacions contradictories";
                }
            }


        }


    }
}
