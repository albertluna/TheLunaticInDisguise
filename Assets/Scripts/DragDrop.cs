using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Vector3 startPos; 

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        startPos = rectTransform.anchoredPosition;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Onbegindrag");
        canvasGroup.alpha = .5f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnENddrag");
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        rectTransform.anchoredPosition = startPos;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Onpointerdown");
    }
}
