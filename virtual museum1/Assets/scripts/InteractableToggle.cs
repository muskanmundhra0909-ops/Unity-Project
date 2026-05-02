using System.Collections.Generic;
using UnityEngine;

public class InteractableToggle : MonoBehaviour
{
    public List<GameObject> infoObjects = new List<GameObject>();
    private bool isOpen = false;

    void Start()
    {
        foreach (GameObject obj in infoObjects)
        {
            obj.SetActive(false); // start me hidden
        }
    }

    public void Toggle()
    {
        isOpen = !isOpen;

        foreach (GameObject obj in infoObjects)
        {
            obj.SetActive(isOpen);
        }
    }
}