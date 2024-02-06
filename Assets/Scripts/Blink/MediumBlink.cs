using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumBlink : Blink
{
    protected override void Start()
    {
        base.Start();
        moveDelay = 0.5f;
        moveSpeed = 3f;
        moveDistance = 5f;
        health = 150f;
    }

    // Update is called once per frame
    void Update()
    {
        IfHealthIs0();

    }
}

