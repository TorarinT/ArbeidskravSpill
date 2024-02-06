using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Blink : MonoBehaviour
{
    public float health;
    public float speed;
    public float delay;
    public float time;
    void Start()
    {
        
    }
    public void MovePattern()
    {
        
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        
    }
    public void IfHealthIs0()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
