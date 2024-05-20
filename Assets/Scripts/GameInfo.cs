using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    public TMP_Text textToShow;
    public float displayTime = 5f;

    private void Start()
    {
        ShowTextForTime();
    }

    private void ShowTextForTime()
    {
        textToShow.enabled = true;
        Invoke("HideText", displayTime);
    }

    private void HideText()
    {
        textToShow.enabled = false;
    }
}
