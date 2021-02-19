using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class arrastrar : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData data)
    {
        transform.position = data.position;
    }


}
