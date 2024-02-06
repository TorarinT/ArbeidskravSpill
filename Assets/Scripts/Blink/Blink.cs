using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Blink : MonoBehaviour
{
    public float health;
    public float moveSpeed;
    public float moveDelay;
    public float moveDistance;
    protected virtual void Start()
    {
        StartCoroutine(MovePattern());
    }
    IEnumerator MovePattern()
    {
        while (true)
        {
            float startTime = Time.time;
            while (Time.time - startTime < moveDistance / moveSpeed)
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(moveDelay);

            startTime = Time.time;
            while (Time.time - startTime < moveDistance / moveSpeed)
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(moveDelay);
        }
    }
    public void IfHealthIs0()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}