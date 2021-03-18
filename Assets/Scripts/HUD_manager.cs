using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD_manager : MonoBehaviour
{
    public GameObject prinotes;
    public GameObject prinparla;
    private parles parles;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        //this.gameObject.SetActive(false);
        prinotes.SetActive(true);
        prinotes.SetActive(true);
        parles = prinparla.GetComponent<parles>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newScene()
    {
        parles.newScene();
    }
}
