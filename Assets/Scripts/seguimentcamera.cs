using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class seguimentcamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject seguir;
    public Vector3 posicioRelativa;
    private Animation cinematiques;

    // Start is called before the first frame update
    void Start()
    {
        cinematiques = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seguir.GetComponent<MovimentSimple>().Mov)
        {
            transform.position = new Vector3(seguir.transform.position.x + posicioRelativa.x, transform.position.y, transform.position.z);
        }
    }

    
}


