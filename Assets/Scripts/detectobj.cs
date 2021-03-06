using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class detectobj : MonoBehaviour, IDropHandler
{
    public GameObject movobj;
    public Mouobj mouobj;
    public GameObject deteobj;
    public detectobj detobj;
    private bool var102 = false;
    private bool var107 = false;
    private bool var406 = false;
    private bool var104 = false;
    public bool var105 = false;
    private bool var122 = false;
    private bool var123 = false;
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
  
  
    public bool contr1 = false;
    public bool contr2 = false;
    public bool contr3 = false;
    public bool contr4 = false;
    public bool contr5 = false;
    public bool contr6 = false;
    public bool contr7 = false;
    public bool contr8 = false;
    private void Start()
    {
        Debug.Log(mouobj);
        detobj = deteobj.GetComponent<detectobj>();
        mouobj = movobj.GetComponentInChildren<Mouobj>();
        Debug.Log(mouobj);
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
        if (detobj.var105 == true)
        {
            if (var408 == true)
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
        if (detobj.var105 == true)
        {
            if (var408 == true)
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
    }
}

