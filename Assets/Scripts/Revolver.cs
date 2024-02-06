using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject muzzleFlash;
    void Start()
    {
        if (muzzleFlash != null)
        {
            muzzleFlash.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Show the muzzle flash
            if (muzzleFlash != null)
            {
                StartCoroutine(ShowMuzzleFlash());
            }
        }

    }
    IEnumerator ShowMuzzleFlash()
    {

        muzzleFlash.SetActive(true);


        yield return new WaitForSeconds(0.1f);


        muzzleFlash.SetActive(false);
    }

}
