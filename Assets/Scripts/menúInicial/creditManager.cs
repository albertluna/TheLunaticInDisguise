using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class creditManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Image image;

    public bool final;
    public string falseFinalText;
    public string trueFinalText;

    public Image falseFinalImage;
    public Image trueFinalImage;

    public void setFinal(bool final)
    {
        this.final = final;
        if (final)
        {
            text.text = trueFinalText;
            image = trueFinalImage;
        } else
        {
            text.text = falseFinalText;
            image = falseFinalImage;
        }
    }
}
