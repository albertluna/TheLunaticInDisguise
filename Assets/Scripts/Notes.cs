using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Notes : MonoBehaviour
{
    public GameObject notas;

    private bool activar = false;

    private string pathOfPrefabDirectory = "Notes/"; //load resources*
    private class MatriuNotes
    {
        public GameObject[] notes;
    }
    private MatriuNotes[] matriu_notes; //Barry = 0 (id 1), Carol = 1 (id 2), Bruce = 2 (id 3), Oliver = 3 (id 4), Pamela = 4 (id 5);

    private KeyCode[] keyCode = new KeyCode[] {
        KeyCode.Alpha1,
        KeyCode.Alpha2,
        KeyCode.Alpha3,
        KeyCode.Alpha4,
        KeyCode.Alpha5
    };

    private int barry = 0, barry2 = 0, carol = 0, pamela = 0, oliver = 0, bruce = 0, oliver2 = 0;

    private int x = -341, y = 125;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            activar = !activar;
            notas.SetActive(activar);
            if (activar)
            {
                for (int i = 0; i < keyCode.Length; i++)
                {
                    if (Input.GetKeyDown(keyCode[i]))
                    {
                        for (int j = 0; j < matriu_notes[i].notes.Length; j++)
                        {
                            matriu_notes[i].notes[j].SetActive(true);
                        }

                        for (int n = 0; n < matriu_notes.Length; n++)
                        {
                            if (n != i)
                            {
                                for (int j = 0; j < matriu_notes[n].notes.Length; j++)
                                {
                                    matriu_notes[n].notes[j].SetActive(false);
                                }
                            }
                        }
                    }
                }
            }
        }

        if (GameObject.Find("Barry").GetComponent<Flowchart>().GetIntegerVariable("Barry") != barry)
        {
            barry = GameObject.Find("Barry").GetComponent<Flowchart>().GetIntegerVariable("Barry");
            createInstance(GameObject.Find("Barry").GetComponent<Flowchart>().GetIntegerVariable("Barry"));
        }

        if (GameObject.Find("Carol").GetComponent<Flowchart>().GetIntegerVariable("Carol") != carol)
        {
            carol = GameObject.Find("Carol").GetComponent<Flowchart>().GetIntegerVariable("Carol");
            createInstance(GameObject.Find("Carol").GetComponent<Flowchart>().GetIntegerVariable("Carol"));
        }

        if (GameObject.Find("Pamela").GetComponent<Flowchart>().GetIntegerVariable("Pamela") != pamela)
        {
            pamela = GameObject.Find("Pamela").GetComponent<Flowchart>().GetIntegerVariable("Pamela");
            createInstance(GameObject.Find("Pamela").GetComponent<Flowchart>().GetIntegerVariable("Pamela"));
        }

        if (GameObject.Find("Oliver").GetComponent<Flowchart>().GetIntegerVariable("Oliver") != oliver)
        {
            oliver = GameObject.Find("Oliver").GetComponent<Flowchart>().GetIntegerVariable("Oliver");
            createInstance(GameObject.Find("Oliver").GetComponent<Flowchart>().GetIntegerVariable("Oliver"));
        }

        if (GameObject.Find("Bruce").GetComponent<Flowchart>().GetIntegerVariable("Bruce") != bruce)
        {
            bruce = GameObject.Find("Bruce").GetComponent<Flowchart>().GetIntegerVariable("Bruce");
            createInstance(GameObject.Find("Bruce").GetComponent<Flowchart>().GetIntegerVariable("Bruce"));
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            activar = false;
            notas.SetActive(activar);
        }
    }

    void createInstance(int id)
    {
        GameObject referencia = Resources.Load<GameObject>(pathOfPrefabDirectory + id.ToString()) as GameObject;
        GameObject nova_nota = Instantiate(referencia, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        nova_nota.transform.SetParent(notas.transform);
        nova_nota.transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);
        nova_nota.transform.localPosition = new Vector3(x, y, -148);
        

        if (x >= 341)
        {
            y -= 125;
            x = -341;
        } else
        {
            x += 341;
        }
        //faltara fer lo de scroll        
        //posar ids de 3 xifres, 123 -> 1 indica personatge, 23 el nombre que es. 
        matriu_notes[id / 100 - 1].notes[matriu_notes[id / 100 - 1].notes.Length - 1] = nova_nota;
    }
}
