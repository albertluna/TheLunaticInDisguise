using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;

public class intent2 : MonoBehaviour
{


    public GameObject panel;

    public string[] SdialogoInicial;
    public string[] SdialogoPelea;
    public string[] SdialogoFinal;
   
    

    //public Text txtDialogo;
    public bool isDialogActive;

    Coroutine auxCorutine;

    public void AbrirCajaDialogo(int valor)
    {

        if(isDialogActive)
        {
            CerrarDialogo();
            StartCoroutine(esperaSolapacionDialogo(valor));
        }




    }


    IEnumerator mostrarDialogo(int valor, float time = 0.1f)
    {
        panel.SetActive(true);
        string[] dialogo;
        if (valor == 0)
        {
            dialogo = SdialogoInicial;
        }
        else if (valor == 1)
        {
            dialogo = SdialogoPelea;
        }
        else
        {
            dialogo = SdialogoFinal;
        }
        int total = dialogo.Length;
        string res = "";
        isDialogActive = true;
        yield return null;
        for (int i = 0; i < total; i++)
        {
            res = "";
            if (isDialogActive)
            {
                for(int s = 0; s < dialogo[i].Length; s++)
                {
                    if (isDialogActive)
                    {
                     res = string.Concat(res, dialogo[i][s]);
                    // txtDialogo.text = res;
                     yield return new WaitForSeconds(time);

                    }
                    else yield break;

                } 
                yield return new WaitForSeconds(0.4f);
            }
            else yield break;
        }
        yield return new WaitForSeconds(0.4f);
     
        CerrarDialogo();

    }
    IEnumerator esperaSolapacionDialogo(int valor)
    {
        yield return new WaitForEndOfFrame();
        auxCorutine = StartCoroutine(mostrarDialogo(valor));
    }

    public void CerrarDialogo()
    {
        isDialogActive = false;
        if (auxCorutine != null)
        {
            
            StopCoroutine(auxCorutine);
            auxCorutine = null;
        }
       // txtDialogo.text = "";
       // panel.setActive(false);

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            AbrirCajaDialogo(0);
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            AbrirCajaDialogo(1);
        }
    }


}
