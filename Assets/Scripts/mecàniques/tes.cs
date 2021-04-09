using UnityEngine;
using Fungus;

public class tes : MonoBehaviour
{
  
    Flowchart flowchart;
    private MovimentSimple moviment;
    private bool started;

    // Start is called before the first frame update
    void Start()
    {
        moviment = GameObject.Find("Robin").GetComponent<MovimentSimple>();
        //moviment = FindObjectOfType<MovimentSimple>();
        flowchart = GetComponent<Flowchart>();
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Dins " + gameObject.name);
        /*Debug.Log("ESpai " + Input.GetKeyDown(KeyCode.Space));
        Debug.Log("KEYOPAD " + Input.GetKeyDown(KeyCode.KeypadEnter));
        Debug.Log("Flowchart " + !flowchart.HasExecutingBlocks());
        Debug.Log("notes obertes?" + !moviment.notesObertes);*/

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter)) && !flowchart.HasExecutingBlocks() && !moviment.notesObertes)
        {
            moviment.Mov = false;
            flowchart.ExecuteBlock("iniciConv");
            started = true;
        }
        //Es repren el moviment Mov a Cinematiques.nouInvestigat();
    }

}
