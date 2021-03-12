using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class detectobj : MonoBehaviour, IDropHandler
{
    public GameObject movobj;
    public Mouobj mouobj;
    public GameObject movobj1;
    public Mouobj mouobj1;
    public GameObject movobj2;
    public Mouobj mouobj2;
    public GameObject movobj3;
    public Mouobj mouobj3;
    public GameObject movobj4;
    public Mouobj mouobj4;
    public GameObject deteobj;
    public detectobj detobj;
    private bool var102 = false;
    private bool var107 = false;
    private bool var406 = false;
    private bool var104 = false;
    public bool var105 = false;
    private bool var122 = false;
    private bool var123 = false;
    private bool var125 = false;
    private bool var121 = false;
    private bool var120 = false;
    private bool var124 = false;
    private bool var207 = false;
    private bool var411 = false;
    private bool var206 = false;
    private bool var201 = false;
    private bool var204 = false;
    private bool var205 = false;
    private bool var208 = false;
    private bool var220 = false;
    private bool var221 = false;
    private bool var222 = false;
    private bool var223 = false;
    private bool var301 = false;
    private bool var407 = false;
    private bool var101 = false;
    private bool var302 = false;
    private bool var303 = false;
    private bool var320 = false;
    private bool var416 = false;
    private bool var401 = false;
    private bool var402 = false;
    private bool var415 = false;
    private bool var409 = false;
    private bool var405 = false;
    private bool var414 = false;
    private bool var413 = false;
    private bool var412 = false;
    private bool var403 = false;
    private bool var404 = false;
    private bool var408 = false;
    private bool var410 = false;
    private bool var422 = false;
    private bool var423 = false;
    private bool var420 = false;
    private bool var421 = false;
    private bool var424 = false;
    private bool var425 = false;
    private bool var106 = false;
    private bool var501 = false;
    private bool var503 = false;
    private bool var504 = false;
    private bool var502 = false;
    private bool var523 = false;
    private bool var521 = false;
    private bool var520 = false;
    private bool var553 = false;
    private bool var552 = false;
    private bool var550 = false;
    private bool var451 = false;
    private bool var150 = false;
    private bool var452 = false;
    private bool var251 = false;
    private bool var351 = false;
    private bool var354 = false;
    private bool var551 = false;



    public bool contr1 = false;
    public bool contr2 = false;
    public bool contr3 = false;
    public bool contr4 = false;
    public bool contr5 = false;
    public bool contr6 = false;
    public bool contr7 = false;
    public bool contr8 = false;
    public bool contr9 = false;
    public bool contr10 = false;
    public bool contr11 = false;
    public bool contr12 = false;
    public bool contr13 = false;
    public bool contr14 = false;
    public bool contr15 = false;
    public bool contr16 = false;
    public bool contr17 = false;
    public bool contr18 = false;
    public bool contr19 = false;
    public bool contr20 = false;

    private void Start()
    {
        Debug.Log(mouobj);
        detobj = deteobj.GetComponent<detectobj>();
        mouobj = movobj.GetComponentInChildren<Mouobj>();
        mouobj2 = movobj.GetComponentInChildren<Mouobj>();
        mouobj3 = movobj.GetComponentInChildren<Mouobj>();
        mouobj4 = movobj.GetComponentInChildren<Mouobj>();
        mouobj1 = movobj.GetComponentInChildren<Mouobj>();
        Debug.Log(mouobj);
        DontDestroyOnLoad(this);
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            
            mouobj = eventData.pointerDrag.GetComponentInChildren<Mouobj>();
         
            Debug.Log(mouobj);
            RectTransform cardRect = eventData.pointerDrag.GetComponent<RectTransform>();
           // cardRect.SetParent(transform, false);
            cardRect.transform.position = transform.position;
            Debug.Log("vaig a fer l'if.idnota: "+ mouobj.idnota);
            if (mouobj.idnota == 105)
            {
                Debug.Log("SI he entrat al if. mouobj.entrat = "+mouobj.entrat);
               
                   // Debug.Log("mouobj.entrat");
                    var105 = true;

                
            }
            else
            {
                Debug.Log("NO he entrat al if");
            }


            if (mouobj.idnota == 408)
            {
              
                
                    var408 = true;

                
            }
            if (mouobj.idnota == 302)
            {
          
                
                    var302 = true;

                
            }
            if (mouobj.idnota == 208)
            {
                
                    var208 = true;

                
            }
            if (mouobj.idnota == 413)
            {
                
                    var413 = true;

                
            }
            if (mouobj.idnota == 303)
            {
                
                    var303 = true;

                
            }
            if (mouobj.idnota == 501)
            {
                
                    var501 = true;

                
            }
            if (mouobj.idnota == 412)
            {
                
                    var412 = true;

                
            }

            if (mouobj.idnota == 523)
            {

                var523 = true;


            }

            if (mouobj.idnota == 521)
            {

                var521 = true;


            }

            if (mouobj.idnota == 520)
            {

                var520 = true;


            }

            if (mouobj.idnota == 553)
            {

                var553 = true;


            }

            if (mouobj.idnota == 552)
            {

                var552 = true;


            }

            if (mouobj.idnota == 550)
            {

                var550 = true;


            }

            if (mouobj.idnota == 451)
            {

                var451 = true;


            }

            if (mouobj.idnota == 150)
            {

                var150 = true;


            }

            if (mouobj.idnota == 452)
            {

                var452 = true;


            }

            if (mouobj.idnota == 251)
            {

                var251 = true;


            }
            
            if (mouobj.idnota == 351)
            {

                var351 = true;


            }

            if (mouobj.idnota == 354)
            {

                var354 = true;


            }
            if (mouobj.idnota == 551)
            {

                var551 = true;


            }






        }
    }
    void Update()
    {
        if(detobj.var105 == true)
        {
            if(var408 == true)
            {
                contr1 = true;
            }
        }
        if (detobj.var208 == true)
        {
            if (var302 == true)
            {
                contr2 = true;
            }
        }
        if (detobj.var303 == true)
        {
            if (var413 == true)
            {
                contr3 = true;
            }
        }
        if (detobj.var501 == true)
        {
            if (var412 == true)
            {
                contr4 = true;
            }
        }




        if (detobj.var125 == true)
        {
            if (var424 == true)
            {
                contr5 = true;
            }
        }
        if (detobj.var424 == true)
        {
            if (var420 == true)
            {
                contr6 = true;
            }
        }
        if (detobj.var425 == true)
        {
            if (var521 == true)
            {
                contr7 = true;
            }
        }
        if (detobj.var523 == true)
        {
            if (var520 == true)
            {
                contr8 = true;
            }
        }




        if (detobj.var552 == true)
        {
            if (var553 == true)
            {
                contr9 = true;
            }
        }
        if (detobj.var550 == true)
        {
            if (var451 == true)
            {
                contr10 = true;
            }
        }
        if (detobj.var150 == true)
        {
            if (var551 == true)
            {
                contr11 = true;
            }
        }
        if (detobj.var452 == true)
        {
            if (var251 == true)
            {
                contr12 = true;
            }
        }


        if (detobj.var351 == true)
        {
            if (var354 == true)
            {
                contr13 = true;
            }
        }
       




















        if (var105 == true)
        {
            if (detobj.var408 == true)
            {
                contr1 = true;
            }
        }
        if (var208 == true)
        {
            if (detobj.var302 == true)
            {
                contr2 = true;
            }
        }
        if (detobj.var303 == true)
        {
            if (var413 == true)
            {
                contr3 = true;
            }
        }
        if (var501 == true)
        {
            if (detobj.var412 == true)
            {
                contr4 = true;
            }
        }

        if (var125 == true)
        {
            if (detobj.var424 == true)
            {
                contr5 = true;
            }
        }
        if (var424 == true)
        {
            if (detobj.var420 == true)
            {
                contr6 = true;
            }
        }
        if (detobj.var425 == true)
        {
            if (detobj.var521 == true)
            {
                contr7 = true;
            }
        }
        if (var523 == true)
        {
            if (detobj.var520 == true)
            {
                contr8 = true;
            }
        }




        if (var552 == true)
        {
            if (detobj.var553 == true)
            {
                contr9 = true;
            }
        }
        if (var550 == true)
        {
            if (detobj.var451 == true)
            {
                contr10 = true;
            }
        }
        if (var150 == true)
        {
            if (detobj.var551 == true)
            {
                contr11 = true;
            }
        }
        if (var452 == true)
        {
            if (detobj.var251 == true)
            {
                contr12 = true;
            }
        }


        if (var351 == true)
        {
            if (detobj.var354 == true)
            {
                contr13 = true;
            }
        }
    }
}

