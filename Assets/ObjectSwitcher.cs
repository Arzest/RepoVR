using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] objectsToToggle;
    private int currentIndex = 0;

    public void OnButtonClick()
    {
        if (objectsToToggle.Length == 0) return;
        objectsToToggle[currentIndex].SetActive(false);
        currentIndex = (currentIndex + 1) % objectsToToggle.Length;
        objectsToToggle[currentIndex].SetActive(true);
    }
}
