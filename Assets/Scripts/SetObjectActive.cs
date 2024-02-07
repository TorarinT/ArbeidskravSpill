using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectActive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject activeObject;
    void Start()
    {
        activeObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
