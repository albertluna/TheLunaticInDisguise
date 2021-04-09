using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class detectobj : MonoBehaviour, IDropHandler
{
    //public GameObject movobj;
    public Mouobj mouobj;
    public GameObject movobj;
    public detectobj detobj;

    public TextMeshProUGUI text;
    public int idNota;
    private detectorContradiccions contradiccions;


    private void Start()
    {
        mouobj = null;//movobj.GetComponentInChildren<Mouobj>();
        contradiccions = GetComponentInParent<detectorContradiccions>();        
    }



    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if(mouobj != null) mouobj.textMesh.SetText(text.text);

            mouobj = eventData.pointerDrag.GetComponentInChildren<Mouobj>();

            Debug.Log(mouobj);
            //RectTransform cardRect = eventData.pointerDrag.GetComponent<RectTransform>();
            // cardRect.SetParent(transform, false);
            //cardRect.transform.position = transform.position;
            Debug.Log("vaig a fer l'if.idnota: " + mouobj.idnota);
            text.SetText(mouobj.text);
            mouobj.textMesh.SetText("");

            idNota = mouobj.idnota;
            contradiccions.esContradiccio();

        }

    }
}
