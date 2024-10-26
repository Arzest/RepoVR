using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCounter : MonoBehaviour
{
    public Text counterText;
    public int initialCounter = 50;
    private int counter;
    public GameObject targetObject; 

    void Start()
    {
        counter = initialCounter;
        UpdateCounterText();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == targetObject)
        {
            counter--;
            UpdateCounterText();
        }
    }

    void UpdateCounterText()
    {
        if (counterText != null)
            counterText.text = "—четчик: " + counter.ToString();
    }

}
