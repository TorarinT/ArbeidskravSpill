using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyBlink : Blink
{
    protected override void Start()
    {
        base.Start();
        moveDelay = 1f;
        moveSpeed = 1f;
        moveDistance = 5f;
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        IfHealthIs0();

    }
}
