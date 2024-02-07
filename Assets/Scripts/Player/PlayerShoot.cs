using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public new Camera camera;
    private Accuracy accuracy;
    void Start()
    {
        camera = Camera.main;
        Cursor.visible = false;
        accuracy = GetComponent<Accuracy>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pressed mouse 0");
            Ray ray = new Ray(camera.transform.position, camera.transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Blink blink = hitInfo.collider.GetComponent<Blink>();
                if (blink != null)
                {
                    accuracy.IncrementHit(); 
                    blink.health -= 50f;
                } else
                {
                    accuracy.IncrementMiss(); // Bommer vis du skyter på et object som ikke er blinken (eksempel bakken)
                }
            }
            else
            {
                accuracy.IncrementMiss(); // Bommer vis du skyter i lufta
            }
        }

    }
}