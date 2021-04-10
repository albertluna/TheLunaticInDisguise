using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class res : MonoBehaviour
{
    // Start is called before the first frame update
    public Button yourButton;
    public GameObject Robin;
    private MovimentSimple moviment;
    public Canvas canvas;
    void Start()
    {
        moviment = Robin.GetComponent<MovimentSimple>();
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        moviment.Mov = true;
        canvas.gameObject.SetActive(false);
    }


}
