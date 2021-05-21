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

    public void setFinal(bool finalDesbloquejat)
    {
        final = finalDesbloquejat;
        if (final)
        {
            text.text = trueFinalText.Replace("\\n", "\n");
            image = trueFinalImage;
        } else
        {
            text.text = falseFinalText.Replace("\\n", "\n");
            image = falseFinalImage;
        }
    }
}
