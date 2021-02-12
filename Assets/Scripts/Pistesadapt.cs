using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pistesadapt : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject changetext;
    private Text MyText;
    bool Pista1 = false;


    void Start()
    {
        MyText.text = "no tens la pista 1";
    }

    // Update is called once per frame
    void Update()
    {
        if (Pista1 == true)
        {
            MyText.text = "has obtingut la pista 1";
        }
    }

   
}
