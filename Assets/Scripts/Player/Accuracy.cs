using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Accuracy : MonoBehaviour
{
    public TextMeshProUGUI accuracyText;
    private int hit;
    private int miss;
    private void Start()
    {
        accuracyText.text = "Accuracy:";
    }
    public void IncrementHit()
    {
        hit++;
        CalculateAccuracy();
    }
    public void IncrementMiss()
    {
        miss++;
        CalculateAccuracy();
    }
    public string GetAccuracy()
    {
        return accuracyText.text;
    }

    public void CalculateAccuracy()
    {
        if (hit + miss > 0)
        {
            float accuracy = (float)hit / (hit + miss) * 100f;
            Debug.Log("Accuracy: " + accuracy.ToString("F2") + "%");
            accuracyText.text = "Accuracy:" +" " + accuracy.ToString("F2")+ "%";
            PlayerPrefs.SetString("accuracyString",accuracyText.text);
            PlayerPrefs.Save();  // Lagrer accuracy texten slik at vi kan bruke d i victory scene
        }  
        else
        {
            Debug.Log("No hits or misses yet.");
        }
    }



}
