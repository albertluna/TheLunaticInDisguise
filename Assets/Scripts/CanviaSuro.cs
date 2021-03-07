using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.XR;

public class CanviaSuro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject detecctobj;
    public detectobj detectobjo;
    public TMP_Text MyText;
    public TMP_Text MyText2;
    public TMP_Text MyText3;
    public TMP_Text MyText4;
    public bool entrat = false;
    public bool entrat2 = false;
    public bool entrat3 = false;
    public bool entrat4 = false;

    void Start()
    {
        detectobjo = detecctobj.GetComponent<detectobj>();
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("detect " + detectobjo);
        Debug.Log("contr1 " + detectobjo.contr1);
        if (detectobjo.contr1 == true)
        {
            entrat = true;
            MyText.text = "Barry: Què va fer ahir a la nit?";
        }

        if (detectobjo.contr2 == true)
        {
            entrat2 = true;
            MyText2.text = "    Carol: Amb qui estava ahir a la nit? ";
        }

        if (detectobjo.contr3 == true)
        {
            entrat3 = true;
            MyText3.text = "Bruce: Va mentir sobre el què va fer";
        }

        if (detectobjo.contr4 == true)
        {
            entrat4 = true;
            MyText4.text = "Pamela: on estava?";
        }
    }
}

