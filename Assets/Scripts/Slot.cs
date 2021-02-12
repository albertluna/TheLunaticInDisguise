using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
        //fer array de parelles amb contradiccions, 
        //mirar si id es a l'array i si esta amb l'altre id, 
        //si sí, mostrar missatge (has trobat algo) i desbloquejar dialeg.
    }
}
