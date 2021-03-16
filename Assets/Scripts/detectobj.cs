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
    /*
    public GameObject deteobj2;
    public detectobj detobj;


    public GameObject deteobj3;
    public detectobj detobj;


    public GameObject deteobj4;
    public detectobj detobj;


    public GameObject deteobj5;
    public detectobj detobj;
    */

    public bool var102 = false;
    public bool var107 = false;
    public bool var108 = false;

    public bool var406 = false;
    public bool var104 = false;
    public bool var105 = false;
    public bool var122 = false;
    public bool var123 = false;
    public bool var125 = false;
    public bool var121 = false;
    public bool var120 = false;
    public bool var124 = false;

    public bool var207 = false;
    public bool var411 = false;
    public bool var206 = false;
    public bool var201 = false;
    public bool var204 = false;
    public bool var205 = false;
    public bool var208 = false;
    public bool var220 = false;
    public bool var221 = false;
    public bool var222 = false;
    public bool var223 = false;
    public bool var301 = false;
    public bool var407 = false;
    public bool var101 = false;
    public bool var302 = false;
    public bool var303 = false;
    public bool var320 = false;
    public bool var416 = false;
    public bool var401 = false;
    public bool var402 = false;
    public bool var415 = false;
    public bool var409 = false;
    public bool var405 = false;
    public bool var414 = false;
    public bool var413 = false;
    public bool var412 = false;
    public bool var403 = false;
    public bool var404 = false;
    public bool var408 = false;
    public bool var410 = false;
    public bool var422 = false;
    public bool var423 = false;
    public bool var420 = false;
    public bool var421 = false;
    public bool var424 = false;
    public bool var425 = false;
    public bool var106 = false;
    public bool var501 = false;
    public bool var503 = false;
    public bool var504 = false;
    public bool var502 = false;
    public bool var523 = false;
    public bool var521 = false;
    public bool var520 = false;
    public bool var553 = false;
    public bool var552 = false;
    public bool var550 = false;
    public bool var451 = false;
    public bool var150 = false;
    public bool var452 = false;
    public bool var251 = false;
    public bool var351 = false;
    public bool var354 = false;
    public bool var551 = false;
    public bool var156 = false;
    public bool var155 = false;
    public bool var153 = false;
    public bool var151 = false;
    public bool var154 = false;
    public bool var209 = false;
    public bool var254 = false;
    public bool var250 = false;
    public bool var253 = false;
    public bool var304 = false;
    public bool var300 = false;
    public bool var323 = false;
    public bool var321 = false;
    public bool var322 = false;
    public bool var352 = false;
    public bool var353 = false;
    public bool var450 = false;
    public bool var453 = false;
    public bool var505 = false;
    public bool var507 = false;
    public bool var524 = false;
    public bool var522 = false;




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
        detobj = deteobj.GetComponent<detectobj>();
        mouobj = movobj.GetComponentInChildren<Mouobj>();
        /* detobj = deteobj2.GetComponent<detectobj>();
         detobj = deteobj3.GetComponent<detectobj>();
         detobj = deteobj4.GetComponent<detectobj>();
         detobj = deteobj5.GetComponent<detectobj>();*/
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
            Debug.Log("vaig a fer l'if.idnota: " + mouobj.idnota);
            if (mouobj.idnota == 105)
            {
                Debug.Log("SI he entrat al if. mouobj.entrat = " + mouobj.entrat);

                Debug.Log("mouobj.entrat");
                var105 = true;


            }
            else
            {
                Debug.Log("NO he entrat al if");
            }

            if (mouobj.idnota == 108)
            {


                var108 = true;


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

            if (mouobj.idnota == 125)
            {

                var125 = true;


            }
            if (mouobj.idnota == 221)
            {

                var221 = true;


            }
            if (mouobj.idnota == 424)
            {

                var424 = true;


            }
            if (mouobj.idnota == 420)
            {

                var420 = true;


            }
            if (mouobj.idnota == 425)
            {

                var425 = true;


            }
            if (mouobj.idnota == 521)
            {

                var521 = true;


            }
            if (mouobj.idnota == 523)
            {

                var523 = true;


            }
            if (mouobj.idnota == 451)
            {

                var451 = true;


            }
            if (mouobj.idnota == 125)
            {

                var125 = true;


            }
            if (mouobj.idnota == 150)
            {

                var150 = true;


            }
            if (mouobj.idnota == 251)
            {

                var251 = true;


            }
        }
    }
    void Update()
    {



        if (detobj.var105 == true)
        {
            var105 = true;

        }

        if (detobj.var108 == true)
        {
            var108 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var303 == true)
        {
            var303 = true;

        }
        if (detobj.var413 == true)
        {
            var413 = true;

        }
        if (detobj.var501 == true)
        {
            var501 = true;

        }
        if (detobj.var412 == true)
        {
            var412 = true;

        }
        if (detobj.var523 == true)
        {
            var523 = true;

        }
        if (detobj.var521 == true)
        {
            var521 = true;

        }
        if (detobj.var520 == true)
        {
            var520 = true;

        }
        if (detobj.var552 == true)
        {
            var552 = true;

        }
        if (detobj.var553 == true)
        {
            var553 = true;

        }
        if (detobj.var550 == true)
        {
            var550 = true;

        }
        if (detobj.var451 == true)
        {
            var451 = true;

        }
        if (detobj.var150 == true)
        {
            var150 = true;

        }
        if (detobj.var551 == true)
        {
            var551 = true;

        }
        if (detobj.var452 == true)
        {
            var452 = true;

        }
        if (detobj.var251 == true)
        {
            var251 = true;

        }
        if (detobj.var351 == true)
        {
            var351 = true;

        }
        if (detobj.var354 == true)
        {
            var354 = true;

        }


        


        if (detobj.var105 == true)
        {
            var105 = true;

        }

        if (detobj.var108 == true)
        {
            var108 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var303 == true)
        {
            var303 = true;

        }
        if (detobj.var413 == true)
        {
            var413 = true;

        }
        if (detobj.var501 == true)
        {
            var501 = true;

        }
        if (detobj.var412 == true)
        {
            var412 = true;

        }
        if (detobj.var523 == true)
        {
            var523 = true;

        }
        if (detobj.var521 == true)
        {
            var521 = true;

        }
        if (detobj.var520 == true)
        {
            var520 = true;

        }
        if (detobj.var552 == true)
        {
            var552 = true;

        }
        if (detobj.var553 == true)
        {
            var553 = true;

        }
        if (detobj.var550 == true)
        {
            var550 = true;

        }
        if (detobj.var451 == true)
        {
            var451 = true;

        }
        if (detobj.var150 == true)
        {
            var150 = true;

        }
        if (detobj.var551 == true)
        {
            var551 = true;

        }
        if (detobj.var452 == true)
        {
            var452 = true;

        }
        if (detobj.var251 == true)
        {
            var251 = true;

        }
        if (detobj.var351 == true)
        {
            var351 = true;

        }
        if (detobj.var354 == true)
        {
            var354 = true;

        }





        if (detobj.var105 == true)
        {
            var105 = true;

        }

        if (detobj.var108 == true)
        {
            var108 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var303 == true)
        {
            var303 = true;

        }
        if (detobj.var413 == true)
        {
            var413 = true;

        }
        if (detobj.var501 == true)
        {
            var501 = true;

        }
        if (detobj.var412 == true)
        {
            var412 = true;

        }
        if (detobj.var523 == true)
        {
            var523 = true;

        }
        if (detobj.var521 == true)
        {
            var521 = true;

        }
        if (detobj.var520 == true)
        {
            var520 = true;

        }
        if (detobj.var552 == true)
        {
            var552 = true;

        }
        if (detobj.var553 == true)
        {
            var553 = true;

        }
        if (detobj.var550 == true)
        {
            var550 = true;

        }
        if (detobj.var451 == true)
        {
            var451 = true;

        }
        if (detobj.var150 == true)
        {
            var150 = true;

        }
        if (detobj.var551 == true)
        {
            var551 = true;

        }
        if (detobj.var452 == true)
        {
            var452 = true;

        }
        if (detobj.var251 == true)
        {
            var251 = true;

        }
        if (detobj.var351 == true)
        {
            var351 = true;

        }
        if (detobj.var354 == true)
        {
            var354 = true;

        }






        if (detobj.var105 == true)
        {
            var105 = true;

        }

        if (detobj.var108 == true)
        {
            var108 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var303 == true)
        {
            var303 = true;

        }
        if (detobj.var413 == true)
        {
            var413 = true;

        }
        if (detobj.var501 == true)
        {
            var501 = true;

        }
        if (detobj.var412 == true)
        {
            var412 = true;

        }
        if (detobj.var523 == true)
        {
            var523 = true;

        }
        if (detobj.var521 == true)
        {
            var521 = true;

        }
        if (detobj.var520 == true)
        {
            var520 = true;

        }
        if (detobj.var552 == true)
        {
            var552 = true;

        }
        if (detobj.var553 == true)
        {
            var553 = true;

        }
        if (detobj.var550 == true)
        {
            var550 = true;

        }
        if (detobj.var451 == true)
        {
            var451 = true;

        }
        if (detobj.var150 == true)
        {
            var150 = true;

        }
        if (detobj.var551 == true)
        {
            var551 = true;

        }
        if (detobj.var452 == true)
        {
            var452 = true;

        }
        if (detobj.var251 == true)
        {
            var251 = true;

        }
        if (detobj.var351 == true)
        {
            var351 = true;

        }
        if (detobj.var354 == true)
        {
            var354 = true;

        }







        if (detobj.var105 == true)
        {
            var105 = true;

        }

        if (detobj.var108 == true)
        {
            var108 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var208 == true)
        {
            var208 = true;

        }
        if (detobj.var302 == true)
        {
            var302 = true;

        }
        if (detobj.var303 == true)
        {
            var303 = true;

        }
        if (detobj.var413 == true)
        {
            var413 = true;

        }
        if (detobj.var501 == true)
        {
            var501 = true;

        }
        if (detobj.var412 == true)
        {
            var412 = true;

        }
        if (detobj.var523 == true)
        {
            var523 = true;

        }
        if (detobj.var521 == true)
        {
            var521 = true;

        }
        if (detobj.var520 == true)
        {
            var520 = true;

        }
        if (detobj.var552 == true)
        {
            var552 = true;

        }
        if (detobj.var553 == true)
        {
            var553 = true;

        }
        if (detobj.var550 == true)
        {
            var550 = true;

        }
        if (detobj.var451 == true)
        {
            var451 = true;

        }
        if (detobj.var150 == true)
        {
            var150 = true;

        }
        if (detobj.var551 == true)
        {
            var551 = true;

        }
        if (detobj.var452 == true)
        {
            var452 = true;

        }
        if (detobj.var251 == true)
        {
            var251 = true;

        }
        if (detobj.var351 == true)
        {
            var351 = true;

        }
        if (detobj.var354 == true)
        {
            var354 = true;

        }











        if (detobj.var105 == true)
        {
            if(var108 == true)
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
            if (detobj.var108 == true)
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

