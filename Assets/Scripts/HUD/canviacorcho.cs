using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canviacorcho : MonoBehaviour
{
    public bool n = false;
    private bool canvi = false;
    public Canvas canvas1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canvi == true)
            {
                if (n == false)
                {
                    canvi = false;
                    n = true;
                    canvas1.gameObject.SetActive(false);
                  
                }
            }


            if (canvi == false)
            {
                if (n == false)
                {
                    canvi = true;
                    n = true;
                    canvas1.gameObject.SetActive(true);
             
                }
            }
            n = false;
        }

    }
}
