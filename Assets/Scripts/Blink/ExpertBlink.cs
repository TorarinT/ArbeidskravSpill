using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpertBlink : Blink
{
    protected override void Start()
    {
        base.Start();
        moveDelay = 0.1f;
        moveSpeed = 12f;
        moveDistance = 5f;
        health = 250f;
    }

    // Update is called once per frame
    void Update()
    {
        IfHealthIs0();

    }
}