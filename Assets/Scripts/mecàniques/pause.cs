using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    public Canvas canvas2;
    public bool activa = false;
    public int n = 0;
    public int b = 0;
    public bool pausat = false;
    public GameObject Robin;
    private MovimentSimple moviment; 
  

    void Start()
    {
        moviment = Robin.GetComponent<MovimentSimple>();
        canvas.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(false);
    }

    // Update is called once per frame


   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (n == 0)
            {
                if (activa == false)
                {
                canvas.gameObject.SetActive(true);
                activa = true;
                n = 1; 
                }
              
            }

            if (n == 0)
            {
                if (activa == true)
                {
                canvas.gameObject.SetActive(false);
                activa = false;
                n = 1;
                }
                
            }
            n = 0;
            if (pausat == false)
            {
                if (b == 0)
                {
                    moviment.Mov = false;
                    pausat = true;
                    b = 1;
                }
            }
            if (pausat == true)
            {
                if (b == 0)
                {
                    moviment.Mov = true;
                    pausat = false;
                    b = 1;

                }
            }
            b = 0;

        }
    }
}
