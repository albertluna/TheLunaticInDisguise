using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Debug.Log("TENIM BOTO");

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("carga menu1");

        ScenesManager.Load(ScenesManager.Scene.Fase_0);
        Debug.Log("carga menu2");
    }
  

}
