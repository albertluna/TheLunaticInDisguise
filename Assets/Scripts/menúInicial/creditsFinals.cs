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



    // Start is called before the first frame update
    void Start()
    {
        /*GameObject.Find("HUD").SetActive(false);
        finalBarry = getVariables.GetBooleanVariable("finalBarry");
        finalBruce = getVariables.GetBooleanVariable("finalBruce");
        finalOliver = getVariables.GetBooleanVariable("finalOliver");
        finalCarol = getVariables.GetBooleanVariable("finalCarol");
        lunaticDescobert = getVariables.GetBooleanVariable("lunaticDescobert");*/

        lunatic.setFinal(lunaticDescobert);
        Barry.setFinal(finalBarry);
        Bruce.setFinal(finalBruce);
        Carol.setFinal(finalCarol);
        Oliver.setFinal(finalOliver);
        Pamela.setFinal(lunaticDescobert);

        moure = true;

        revelacions = GetComponentsInChildren<creditManager>();
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("referencia.y==" + referencia.position + ". lunatics.y== " + Barry.transform.position);
        if (Vector3.Distance(referencia.position, revelacions[index].transform.position) < 10 && moure) {
            Debug.Log("WAIT");
            index++;
            StartCoroutine(waiter());
        }
        if(moure) {
            this.transform.Translate(new Vector3(0, 1, 0));
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            moure = !moure;
        }
    }

    IEnumerator waiter()
    {
        moure = false;
        yield return new WaitForSeconds(5);
        moure = true;
        if(index+1==revelacions.Length)
        {
            moure = false;
            yield return new WaitForSeconds(2);
            ScenesManager.Load(ScenesManager.Scene.menu);
        }
    }
}
