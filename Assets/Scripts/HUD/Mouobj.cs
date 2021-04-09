using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class Mouobj : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
   // [SerializeField] private Sprite sprite;
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;
    private Vector2 startPosition;

    public int idnota;
    public string text;
    public TextMeshProUGUI textMesh;
    public detectobj slot;
    public GameObject blaus;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        canvas = GetComponentInParent<Canvas>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // check if the card has been placed in a slot

        // slot = GetComponentInParent<detectobj>();
        canvasGroup.blocksRaycasts = true;
        //Operacio per retornar a la posicio inicial
        //transform.position = startPosition;

        /*if (!slot)
        {
            transform.position = startPosition;
            canvasGroup.blocksRaycasts = true;
            Debug.Log("FAIL");
            
        } else
        {
            Debug.Log(slot.idNota);
            Debug.Log("OLEE");
        }*/
    }

    public void activar()
    {
        textMesh.text = text;
    }
}
