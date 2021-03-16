using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hab_notes : MonoBehaviour
{
    public bool n = false;
    private bool canvi = false;
    public Canvas canvas1;
    public Canvas canvas2;
    public Canvas canvas3;
    public Canvas canvas4;
    public Canvas canvas5;
   
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (canvi == true)
            {
                if (n == false)
                {
                    canvi = false;
                    n = true;
                    canvas1.gameObject.SetActive(false);
                    canvas2.gameObject.SetActive(false);
                    canvas3.gameObject.SetActive(false);
                    canvas4.gameObject.SetActive(false);
                    canvas5.gameObject.SetActive(false);


                }
            }


            if (canvi == false)
            {
                if (n == false)
                {
                    canvi = true;
                    n = true;
                    canvas1.gameObject.SetActive(true);
                    canvas2.gameObject.SetActive(false);
                    canvas3.gameObject.SetActive(false);
                    canvas4.gameObject.SetActive(false);
                    canvas5.gameObject.SetActive(false);

                }
            }
            n = false;
        }    
    }
}