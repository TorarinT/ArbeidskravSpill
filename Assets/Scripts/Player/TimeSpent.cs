using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeSpent : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI timeSpentText;
    private float increaseBy1Sec = 1f;
    private float currentNumber = 0f;
    void Start()
    {
        timeSpentText.text = "Time Spent: 0 seconds";
    }

    // Update is called once per frame
    void Update()
    {
        currentNumber += increaseBy1Sec * Time.deltaTime;
        timeSpentText.text = "Time Spent:" + " " + currentNumber + " " + "Seconds";
        PlayerPrefs.SetFloat("timeSpentFloat", currentNumber);
        PlayerPrefs.Save();
    }
}
