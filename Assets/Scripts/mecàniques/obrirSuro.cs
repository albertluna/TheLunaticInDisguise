using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obrirSuro : MonoBehaviour
{
    public GameObject suro;
    public MovimentSimple moviment;

    // Start is called before the first frame update
    void Start()
    {
        suro = GameObject.Find("HUD").GetComponent<HUD_manager>().suro;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            activarSuro(false);
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            activarSuro(true);
        }
    }

    //true per obrir i false per tancar el suro
    public void activarSuro(bool enable)
    {
        suro.SetActive(enable);
        moviment.Mov = !enable;
    }
}
