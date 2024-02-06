using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyBlink : Blink
{
    
    
    void Start()
    {
        health = 100f;
        speed = 40f;
        delay = 0.1f;
        time = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MovePattern();
    }
}
