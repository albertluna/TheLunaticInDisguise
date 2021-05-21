using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanviaSuro : MonoBehaviour
{
    // Start is called before the first frame update
    public contradiccioSuro[] suros;
    public GameObject fons;
    public bool isActive;


    void Start()
    {
        suros = GetComponentsInChildren<contradiccioSuro>();
    }

    public void novesContradiccions(int id)
    {
        foreach(contradiccioSuro contradiccions in suros)
        {
            if (id == contradiccions.idContradiccio)
            {
                Debug.Log("NOVA CONTRADICCIO");
                contradiccions.activar();
            }
        }
    } 
}

