using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private Camera cam;
    private float distance = 10f;
    public LayerMask layerMask;
    public Blink blink;
    void Start()
    {
        
        cam = GetComponent<FPSController>().playerCamera;
    }

    
    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); 
        Debug.DrawRay(ray.origin, ray.direction);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo, distance, layerMask))
        {
            if (hitInfo.collider.GetComponent<Blink>()) {
                // To do, fjerne liv fra blinken når man klikker mouse0
            }
            Debug.Log("Hit something");
            
        }   
        
    }
}
