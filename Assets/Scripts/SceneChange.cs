using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public bool isStreet;

    private void OnTriggerEnter2D()
    {
        Debug.Log("CANVI ESCENA");
        if (isStreet)
        {
            ScenesManager.Load(ScenesManager.Scene.escena_habitacio);
        } else
        {
            ScenesManager.Load(ScenesManager.Scene.escena_carrer);
        }
    }
}