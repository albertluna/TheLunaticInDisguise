using System.Collections;
using UnityEngine;
using Fungus;

public class creditsFinals : MonoBehaviour
{
    public bool finalBarry;
    public bool finalBruce;
    public bool finalOliver;
    public bool finalCarol;
    public bool lunaticDescobert;
    public string acusat;
    public Flowchart getVariables;

    public creditManager lunatic;
    public creditManager Barry;
    public creditManager Bruce;
    public creditManager Carol;
    public creditManager Oliver;
    public creditManager Pamela;

    public Transform referencia;
    public bool moure;

    public creditManager[] revelacions;
    public int index;
    public GameObject final;

    void Start()
    {
        Flowchart getVariables = GameObject.Find("GlobalVariables").GetComponent<Flowchart>();

        acusat = getVariables.GetStringVariable("Acusat");
        lunaticDescobert = acusat.Equals("Pamela");

        lunatic.setFinal(lunaticDescobert);
        lunatic.mal.text = lunatic.mal.text.Replace("guess", acusat);
        Barry.setFinal(getVariables.GetBooleanVariable("finalBarry"));
        Bruce.setFinal(getVariables.GetBooleanVariable("finalBruce"));
        Carol.setFinal(getVariables.GetBooleanVariable("finalCarol"));
        Oliver.setFinal(getVariables.GetBooleanVariable("finalOliver"));
        Pamela.setFinal(lunaticDescobert);

        moure = true;

        revelacions = GetComponentsInChildren<creditManager>();
        index = 0;
    }

    void Update()
    {
        if (Vector3.Distance(referencia.position, revelacions[index].transform.position) < 10 && moure) {

            index++;
            StartCoroutine(waiter());
            if (index == revelacions.Length) index = 0;
        }
        if(moure) {
            this.transform.Translate(new Vector3(0, 1, 0));
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            moure = !moure;
        }
        if (Vector3.Distance(referencia.position, final.transform.position) < 20)
        {
            ScenesManager.Load(ScenesManager.Scene.menu);
        }
    }

    IEnumerator waiter()
    {
        moure = false;
        yield return new WaitForSeconds(5);
        moure = true;
        
    }
}
