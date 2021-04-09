using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contradiccioSuro : MonoBehaviour
{
    public int idContradiccio;
    public string text;
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public void activar()
    {
        textMesh.SetText(text);
    }
}
