using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaImage1 : MonoBehaviour
{
    public GameObject targetCanvas; // Assign in Inspector
    public GameObject button; // Assign in Inspector

    public void ShowCanvas()
    {
        targetCanvas.SetActive(true);
        button.SetActive(false);
    }

    public void HideCanvas()
    {
        targetCanvas.SetActive(false);
        button.SetActive(true);
    }
}
