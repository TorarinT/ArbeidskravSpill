using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VictoryAccuracy : MonoBehaviour
{
    public TextMeshProUGUI victoryAccuracyText;

    void Start()
    {
        string accuracy = PlayerPrefs.GetString("accuracyString");
        victoryAccuracyText.text = accuracy;
        Debug.Log(victoryAccuracyText.text);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
