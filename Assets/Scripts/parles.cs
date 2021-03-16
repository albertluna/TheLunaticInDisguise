using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parles : MonoBehaviour
{
    public GameObject Barry;
    public GameObject Bruce;
    public GameObject Carol;
    public GameObject Oliver;
    public GameObject Pamela;

    private Flowchart BarryFc;
    private Flowchart BruceFc;
    private Flowchart CarolFc;
    private Flowchart OliverFc;
    private Flowchart PamelaFc;


    public bool ba102 = false;
    public bool ba107 = false;
    public bool ba101 = false;
    public bool ba104 = false;
    public bool ba105 = false;
    public bool ba108 = false;
    public bool ba122 = false;
    public bool ba123 = false;
    public bool ba121 = false;
    public bool ba120 = false;
    public bool ba125 = false;
    public bool ba124 = false;
    public bool ba156 = false;
    public bool ba155 = false;
    public bool ba153 = false;
    public bool ba151 = false;
    public bool ba150 = false;
    public bool ba154 = false;
    public bool car207 = false;
    public bool car209 = false;
    public bool car206 = false;
    public bool car211 = false;
    public bool car201 = false;
    public bool car204 = false;
    public bool car205 = false;
    public bool car208 = false;
    public bool car220 = false;
    public bool car221 = false;
    public bool car222 = false;
    public bool car223 = false;
    public bool car250 = false;
    public bool car254 = false;
    public bool car251 = false;
    public bool car253 = false;
    public bool br301 = false;
    public bool br307 = false;
    public bool br304 = false;
    public bool br300 = false;
    public bool br302 = false;
    public bool br303 = false;
    public bool br323 = false;
    public bool br321 = false;
    public bool br322 = false;
    public bool br320 = false;
    public bool br354 = false;
    public bool br351 = false;
    public bool br350 = false;
    public bool br352 = false;
    public bool br353 = false;
    public bool ol416 = false;
    public bool ol401 = false;
    public bool ol402 = false;
    public bool ol409 = false;
    public bool ol405 = false;
    public bool ol403 = false;
    public bool ol404 = false;
    public bool ol415 = false;
    public bool ol414 = false;
    public bool ol413 = false;
    public bool ol412 = false;
    public bool ol410 = false;
    public bool ol422 = false;
    public bool ol408 = false;
    public bool ol423 = false;
    public bool ol420 = false;
    public bool ol421 = false;
    public bool ol424 = false;
    public bool ol425 = false;
    public bool ol450 = false;
    public bool ol453 = false;
    public bool ol451 = false;
    public bool ol452 = false;
    public bool pam505 = false;
    public bool pam507 = false;
    public bool pam501 = false;
    public bool pam503 = false;
    public bool pam504 = false;
    public bool pam502 = false;
    public bool pam523 = false;
    public bool pam524 = false;
    public bool pam520 = false;
    public bool pam521 = false;
    public bool pam522 = false;
    public bool pam552 = false;
    public bool pam553 = false;
    public bool pam550 = false;
    public bool pam551 = false;
    public bool pam506 = false;



    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        BarryFc = Barry.GetComponent<Flowchart>();
        BruceFc = Bruce.GetComponent<Flowchart>();
        CarolFc = Carol.GetComponent<Flowchart>();
        OliverFc = Oliver.GetComponent<Flowchart>();
        PamelaFc = Pamela.GetComponent<Flowchart>();

    }

    // Update is called once per frame
    void Update()
    {
        int notabarry1 = BarryFc.GetIntegerVariable("Barry");

        if (notabarry1 == 102)
        {

            ba102 = true;
        }

        if (notabarry1 == 107)
        {

            ba107 = true;
        }

        if (notabarry1 == 101)
        {

            ba101 = true;
        }

        if (notabarry1 == 104)
        {

            ba104 = true;
        }

        if (notabarry1 == 122)
        {

            ba122 = true;
        }

        if (notabarry1 == 105)
        {

            ba105 = true;
        }
        if (notabarry1 == 123)
        {

            ba123 = true;
        }

        if (notabarry1 == 121)
        {

            ba121 = true;
        }

        if (notabarry1 == 120)
        {

            ba120 = true;
        }

        if (notabarry1 == 125)
        {

            ba125 = true;
        }

        if (notabarry1 == 124)
        {

            ba124 = true;
        }

        if (notabarry1 == 156)
        {

            ba156 = true;
        }
        if (notabarry1 == 155)
        {

            ba155 = true;
        }

        if (notabarry1 == 153)
        {

            ba153 = true;
        }

        if (notabarry1 == 151)
        {

            ba151 = true;
        }

        if (notabarry1 == 150)
        {

            ba150 = true;
        }

        if (notabarry1 == 154)
        {

            ba154 = true;

        }
        if (notabarry1 == 999)
        {

           
        }

        int notabarry2 = BruceFc.GetIntegerVariable("Bruce");


        if (notabarry2 == 301)
        {

            br301 = true;
        }

        if (notabarry2 == 307)
        {

            br307 = true;
        }

        if (notabarry2 == 300)
        {

            br300 = true;
        }

        if (notabarry2 == 302)
        {

            br302 = true;
        }

        if (notabarry2 == 303)
        {

            br303 = true;
        }

        if (notabarry2 == 323)
        {

            br323 = true;

        }
            if (notabarry2 == 321)
        {

            br321 = true;
        }

        if (notabarry2 == 320)
        {

            br320 = true;
        }

        if (notabarry2 == 322)
        {

            br322 = true;
        }

        if (notabarry2 == 354)
        {
            br354 = true;
        }

        if (notabarry2 == 351)
        {

            br351 = true;
        }

        if (notabarry2 == 350)
        {

            br350 = true;
        }
        if (notabarry2 == 352)
        {

            br352 = true; ;
        }

        if (notabarry2 == 353)
        {

            br353 = true;
        }

        
        int notabarry3 = CarolFc.GetIntegerVariable("Carol");


        if (notabarry3 == 207)
        {

            car207 = true;
        }

        if (notabarry3 == 211)
        {

            car211 = true;
        }

        if (notabarry3 == 206)
        {

            car206 = true;
        }

        if (notabarry3 == 201)
        {

            car201 = true;
        }

        if (notabarry3 == 204)
        {

            car204 = true;
        }

        if (notabarry3 == 205)
        {

            car205 = true;
        }
        if (notabarry3 == 208)
        {

            car208 = true;
        }

        if (notabarry3 == 999)
        {

          
        }

        if (notabarry3 == 998)
        {

           
        }

        if (notabarry3 == 220)
        {

            car220 = true;
        }

        if (notabarry3 == 221)
        {

            car221 = true;
        }

        if (notabarry3 == 222)
        {

            car222 = true;
        }
        if (notabarry3 == 223)
        {

            car223 = true;
        }

        if (notabarry3 == 254)
        {

            car254 = true;
        }

        if (notabarry3 == 250)
        {

            car250 = true;
        }

        if (notabarry3 == 997)
        {

          
        }

        if (notabarry3 == 251)
        {

            car251 = true;

        }
        if (notabarry3 == 253)
        {

            car253 = true;
        }
        int notabarry4 = OliverFc.GetIntegerVariable("Oliver");


        if (notabarry4 == 416)
        {

            ol416 = true;
        }

        if (notabarry4 == 401)
        {

            ol401 = true;
        }

        if (notabarry4 == 402)
        {

            ol402 = true;
        }

        if (notabarry4 == 415)
        {

            ol415 = true;
        }

        if (notabarry4 == 409)
        {

            ol409 = true;
        }

        if (notabarry4 == 405)
        {

            ol405 = true;
        }
        if (notabarry4 == 414)
        {

            ol414 = true;
        }

        if (notabarry4 == 413)
        {

            ol413 = true;
        }

        if (notabarry4 == 412)
        {

            ol412 = true;
        }

        if (notabarry4 == 403)
        {

            ol403 = true;
        }

        if (notabarry4 == 404)
        {

            ol404 = true;
        }

        if (notabarry4 == 408)
        {

            ol408 = true;
        }
        if (notabarry4 == 410)
        {

            ol410 = true;
        }

        if (notabarry4 == 422)
        {

            ol422 = true;
        }

        if (notabarry4 == 423)
        {

            ol423 = true;
        }

        if (notabarry4 == 420)
        {

            ol420 = true;
        }

        if (notabarry4 == 421)
        {

            ol421 = true;

        }
        if (notabarry4 == 424)
        {
            ol424 = true;
        }
        if (notabarry4 == 425)
        {
            ol425 = true;
        }
        if (notabarry4 == 450)
        {
            ol450 = true;
        }
        if (notabarry4 == 453)
        {
            ol453 = true;
        }
        if (notabarry4 == 451)
        {
            ol451 = true;
        }
        if (notabarry4 == 452)
        {
            ol452 = true;
        }
        if (notabarry4 == 999)
        {
         
        }

        int notabarry5 = PamelaFc.GetIntegerVariable("Pamela");


        if (notabarry5 == 999)
        {

            
        }

        if (notabarry5 == 505)
        {
            pam505 = true;
        }

        if (notabarry5 == 506)
        {

            pam506 = true;
        }

        if (notabarry5 == 501)
        {

            pam501 = true;
        }

        if (notabarry5 == 503)
        {

            pam503 = true;
        }

        if (notabarry5 == 504)
        {

            pam504 = true;
        }
        if (notabarry5 == 502)
        {

            pam502 = true;
        }

        if (notabarry5 == 523)
        {

            pam523 = true;
        }

        if (notabarry5 == 524)
        {

            pam524 = true;
        }

        if (notabarry5 == 520)
        {
            pam520 = true;
        }

        if (notabarry5 == 521)
        {

            pam521 = true;
        }

        if (notabarry5 == 522)
        {

            pam522 = true;
        }
        if (notabarry5 == 552)
        {

            pam552 = true;
        }

        if (notabarry5 == 553)
        {

            pam553 = true;
        }

        if (notabarry5 == 550)
        {
            pam550 = true;
        }

        if (notabarry5 == 551)
        {
            pam551 = true;

        }


    }
}
