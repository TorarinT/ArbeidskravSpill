using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBlink : Blink
{
    protected override void Start()
    {
        base.Start();
        moveDelay = 0.3f;
        moveSpeed = 8f;
        moveDistance = 5f;
        health = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        IfHealthIs0();

    }
}
