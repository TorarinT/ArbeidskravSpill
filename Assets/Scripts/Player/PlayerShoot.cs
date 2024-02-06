using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public new Camera camera;
    void Start()
    {
        camera = Camera.main;
        Cursor.visible = false;
    }

    // Update is called once per frame
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
                    blink.health -= 50f;
                }
            }
        }

    }
}