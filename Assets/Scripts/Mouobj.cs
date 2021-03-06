using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mouobj : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
   // [SerializeField] private Sprite sprite;
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Vector2 startPosition;
    public int idnota;
    public bool entrat = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
       // rectTransform.anchoredPosition += eventData.delta / sprite.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // check if the card has been placed in a slot
        detectobj slot = GetComponentInParent<detectobj>();
        if (!slot)
        {
            transform.position = startPosition;
            canvasGroup.blocksRaycasts = true;
            
        }
    }
}
