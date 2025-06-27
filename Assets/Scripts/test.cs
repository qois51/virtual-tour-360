using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    // Assign these in the Inspector
    public GameObject objectToHide;
    public GameObject objectToShow;

    // Hide/show objects when button is clicked
    public void ToggleObjects()
    {
        objectToHide.SetActive(false);
        objectToShow.SetActive(true);
    }

}