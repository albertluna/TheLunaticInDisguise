using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class creditManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI be;
    [SerializeField] private TextMeshProUGUI mal;
    [SerializeField] private Image image;

    public bool final;
    [SerializeField] private string falseFinalText;
    [SerializeField] private string trueFinalText;

    [SerializeField] private Image falseFinalImage;
    [SerializeField] private Image trueFinalImage;

    private void Start()
    {
        be.gameObject.SetActive(false);
        mal.gameObject.SetActive(false);
    }

    public void setFinal(bool finalDesbloquejat)
    {

        final = finalDesbloquejat;
        
        if (final)
        {
            be.gameObject.SetActive(true);
            //text.text = trueFinalText.Replace("\\n", "\n");
            image = trueFinalImage;
        } else
        {
            mal.gameObject.SetActive(true);
            //text.text = falseFinalText.Replace("\\n", "\n");
            image = falseFinalImage;
        }
    }
}
