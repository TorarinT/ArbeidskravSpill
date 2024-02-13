using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int blink;
    [SerializeField] TextMeshProUGUI amountOfBlinks;
    void Start()
    {
        blink = GameObject.FindGameObjectsWithTag("Blink").Length;
        Debug.Log(blink.ToString() + " " + "blinks" + "remaining");
    }

    // Update is called once per frame
    void Update()
    {
        blink = GameObject.FindGameObjectsWithTag("Blink").Length;
        amountOfBlinks.text = "Blinks Remaining:" + " " + blink;
    }
}
