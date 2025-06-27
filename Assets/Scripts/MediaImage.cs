using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaImage : MonoBehaviour
{
    public GameObject targetCanvas; // Assign in Inspector

    public void ShowCanvas()
    {
        targetCanvas.SetActive(true);
    }

    public void HideCanvas()
    {
        targetCanvas.SetActive(false);
    }
}
