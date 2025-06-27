using UnityEngine;
using UnityEngine.EventSystems; // Added missing namespace
using System.Collections.Generic;

public class SphereSelector : MonoBehaviour, IPointerClickHandler
{
    public GameObject hideTarget;
    public GameObject[] showTargets;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (hideTarget != null)
        {
            hideTarget.SetActive(false);
        }

        foreach (GameObject target in showTargets)
        {
            if (target != null)
            {
                target.SetActive(true);
            }
        }
    }
}