using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VictoryTotalTime : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI victoryTotalTimeText;
    void Start()
    {
        float timeSpent = PlayerPrefs.GetFloat("timeSpentFloat");
        victoryTotalTimeText.text = "Time Spent:" + " " + timeSpent + " " + "Seconds";
        Debug.Log(timeSpent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
